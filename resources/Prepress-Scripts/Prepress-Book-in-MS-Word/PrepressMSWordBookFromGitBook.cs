using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

class PrepressMSWordBookFromGitBook
{
    const string inputFileName =
        @"C:\Software-University\Programming-Basics-Book-CSharp-BG\resources\Prepress-Scripts\short-sample.docx";
    static Application wordApp;
    const int True = -1;
    const int False = 0;

    static void Main()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        Execute(StartMSWord, "Starting MS Word");
        wordApp.Visible = true; // Show / hide MS Word application window
        wordApp.ScreenUpdating = true; // Set Enable / disable MS Word screen updates after each change

        Execute(OpenBookWordFile, String.Format("Opening MS Word document {0}...", inputFileName));
        Execute(FixPageSizeAndMargins, "Fixing page size and margins");
        Execute(FixNonBreakingSpaces, "Fixing non-breaking-spaces");
        Execute(AdjustDocumentStyles, "Fixing document styles");
        Execute(FixFonts, "Fixing fonts");
        Execute(FixHeadings, "Fixing text headings (applying styles)");
        Execute(FixTables, "Fixing tables");
        Execute(FixImageSizes, "Fixing image sizes");
        //Execute(FixDocumentLanguage, "Fixing document language");

        stopwatch.Stop();
        wordApp.Visible = true;
        Console.WriteLine("Total time: {0}", stopwatch.Elapsed);
    }

    static void FixFonts()
    {
        // Process non-heading paragraphs
        var finder = wordApp.ActiveDocument.Content.Find;
        finder.ClearFormatting();
        finder.Replacement.ClearFormatting();
        finder.Font.Name = "Times New Roman";
        finder.Replacement.Font.Name = "Lato Light";
        finder.Replacement.Font.Size = 11;
        finder.Execute(Replace: WdReplace.wdReplaceAll);

        finder.ClearFormatting();
        finder.Replacement.ClearFormatting();
        finder.Font.Name = "Consolas";
        finder.Replacement.Font.Name = "Consolas";
        finder.Replacement.Font.Size = 11;
        finder.Execute(Replace: WdReplace.wdReplaceAll);
    }

    static void FixNonBreakingSpaces()
    {
        var finder = wordApp.Selection.Find;
        finder.ClearFormatting();
        finder.Text = "^s";
        finder.Replacement.ClearFormatting();
        finder.Replacement.Text = " ";
        finder.Execute(Replace: WdReplace.wdReplaceAll);
    }

    static void FixHeadings()
    {
        foreach (Paragraph par in wordApp.ActiveDocument.Paragraphs)
        {
            int outlineLevel = (int)par.OutlineLevel;
            if (outlineLevel >= 1 && outlineLevel <= 6)
            {
                // Process headings
                par.set_Style("Heading " + outlineLevel);
            }
            else
            {
                // Process paragraphs
                var parFormat = par.Range.ParagraphFormat;
                parFormat.SpaceBeforeAuto = False;
                parFormat.SpaceBefore = 5;
                parFormat.SpaceAfterAuto = False;
                parFormat.SpaceAfter = 5;

                // Process lists (bullets / numbered list / nested bullets)
                if (par.Range.ListFormat.ListType != WdListType.wdListNoNumbering)
                {
                    parFormat.FirstLineIndent = CentimetersToPoints(-0.4);
                    var leftIndent = 0.8 * par.Range.ListFormat.ListLevelNumber + 0.1;
                    parFormat.LeftIndent = CentimetersToPoints(leftIndent);
                    parFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                    parFormat.TabStops.ClearAll();
                }

                // Process source code blocks
                if (par.Range.Font.Name == "Consolas")
                {            
                    parFormat.SpaceBeforeAuto = False;
                    parFormat.SpaceBefore = 0;
                    parFormat.SpaceAfterAuto = False;
                    parFormat.SpaceAfter = 0;
                    par.Range.NoProofing = True;
                }
            }
        }
    }

    static void FixTables()
    {
        var pageWidth = CalcPageWidth();
        foreach (Table table in wordApp.ActiveDocument.Tables)
        {
            table.PreferredWidthType = WdPreferredWidthType.wdPreferredWidthAuto;
            table.Range.ParagraphFormat.SpaceBefore = 0;
            table.Range.ParagraphFormat.SpaceAfter = 0;
        }
    }

    static void StartMSWord()
    {
        wordApp = new Application();
        wordApp.Visible = true;
    }

    static void OpenBookWordFile()
    {
        wordApp.Documents.Open(inputFileName);
    }

    static void AdjustDocumentStyles()
    {
        var headingFonts = new Dictionary<string, dynamic> {
            {"Heading 1", new { size=24, before=0, after=6 } },
            {"Heading 2", new { size=16, before=12, after=6 }},
            {"Heading 3", new { size=14, before=11, after=6 }},
            {"Heading 4", new { size=12, before=10, after=5 }},
            {"Heading 5", new { size=11, before=9, after=5 }},
            {"Heading 6", new { size=11, before=8, after=5 }},
        };

        for (int size = 1; size <= 6; size++)
            AdjustHeadingStyle(size);

        void AdjustHeadingStyle(int headingSize)
        {
            var headingName = "Heading " + headingSize;
            var headingStyle = wordApp.ActiveDocument.Styles[headingName];
            headingStyle.Font.Name = "Lato Medium";
            headingStyle.Font.Bold = False;
            headingStyle.Font.Size = headingFonts[headingName].size;
            headingStyle.ParagraphFormat.SpaceBeforeAuto = False;
            headingStyle.ParagraphFormat.SpaceBefore = headingFonts[headingName].before;
            headingStyle.ParagraphFormat.SpaceAfterAuto = False;
            headingStyle.ParagraphFormat.SpaceAfter = headingFonts[headingName].after;
            headingStyle.set_BaseStyle("");
            headingStyle.set_NextParagraphStyle(wordApp.ActiveDocument.Styles["Normal"]);
            if (headingStyle.ParagraphFormat.OutlineLevel == WdOutlineLevel.wdOutlineLevel1)
                headingStyle.ParagraphFormat.PageBreakBefore = True;
            headingStyle.Font.Color = WdColor.wdColorAutomatic;
            headingStyle.LanguageID = WdLanguageID.wdBulgarian;
        }

        var normalStyle = wordApp.ActiveDocument.Styles["Normal"];
        normalStyle.Font.Name = "Lato Light";
        normalStyle.Font.Size = 11;
        normalStyle.LanguageID = WdLanguageID.wdBulgarian;
        normalStyle.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify;
        normalStyle.ParagraphFormat.SpaceBefore = 5;
        normalStyle.ParagraphFormat.SpaceAfter = 5;

        //wordApp.ActiveDocument.Styles.Add("Table Body", WdStyleType.wdStyleTypeParagraph);
        //var tableBodyStyle = wordApp.ActiveDocument.Styles["Table Body"];
        //tableBodyStyle.set_BaseStyle("Normal");
        ////tableBodyStyle.Font = new Font();
        //tableBodyStyle.ParagraphFormat.SpaceBefore = 0;
        //tableBodyStyle.ParagraphFormat.SpaceAfter = 0;
        //tableBodyStyle.ParagraphFormat.OutlineLevel = WdOutlineLevel.wdOutlineLevelBodyText;


        //var finder = wordApp.Selection.Find;
        //FixHeadingParagraphs(WdOutlineLevel.wdOutlineLevel1, "Heading 1");
        //FixHeadingParagraphs(WdOutlineLevel.wdOutlineLevel2, "Heading 2");
        //FixHeadingParagraphs(WdOutlineLevel.wdOutlineLevel3, "Heading 3");
        //FixHeadingParagraphs(WdOutlineLevel.wdOutlineLevel4, "Heading 4");
        //FixHeadingParagraphs(WdOutlineLevel.wdOutlineLevel5, "Heading 5");
        //FixHeadingParagraphs(WdOutlineLevel.wdOutlineLevel6, "Heading 6");

        //void FixHeadingParagraphs(WdOutlineLevel outlineLevel, string headingName)
        //{
        //    finder.ClearFormatting();
        //    finder.ParagraphFormat.OutlineLevel = outlineLevel;
        //    finder.Replacement.ClearFormatting();
        //    finder.Replacement.set_Style(headingName);
        //    finder.Execute(Replace: WdReplace.wdReplaceAll);
        //}
    }

    static void FixImageSizes()
    {
        var pageWidth = CalcPageWidth();

        foreach (InlineShape shape in wordApp.ActiveDocument.InlineShapes)
        {
            if (shape.Type == WdInlineShapeType.wdInlineShapePicture)
            {
                if (shape.AlternativeText.Contains("alert-icon.png"))
                {
                    // Alert icon --> make it "width:50%; height:50%"
                    shape.ScaleWidth = 50;
                    shape.ScaleHeight = 50;
                }
                else if (shape.ScaleWidth != 100 || shape.ScaleHeight != 100)
                {
                    // Make all images "width:100%; height:100%"
                    shape.ScaleWidth = 100;
                    shape.ScaleHeight = 100;
                }
                if (shape.Width > pageWidth)
                {
                    // Resize large images to fit in the page
                    var ratio = (pageWidth / shape.Width) * 100;
                    shape.ScaleWidth = ratio;
                    shape.ScaleHeight = ratio;
                }
            }
        }
    }

    static void FixDocumentLanguage()
    {
        wordApp.Selection.WholeStory();
        wordApp.Selection.LanguageID = WdLanguageID.wdBulgarian;
        wordApp.Selection.NoProofing = False;
        wordApp.Selection.Start = 0;
        wordApp.Selection.End = 0;
    }

    static void FixPageSizeAndMargins()
    {
        var pageSetup = wordApp.ActiveDocument.PageSetup;
        pageSetup.PageWidth = CentimetersToPoints(18);
        pageSetup.PageHeight = CentimetersToPoints(24);

        pageSetup.MirrorMargins = True;
        pageSetup.LeftMargin = CentimetersToPoints(1.5);
        pageSetup.RightMargin = CentimetersToPoints(1);
        pageSetup.TopMargin = CentimetersToPoints(1);
        pageSetup.BottomMargin = CentimetersToPoints(1);

        pageSetup.HeaderDistance = CentimetersToPoints(1.25);
        pageSetup.FooterDistance = CentimetersToPoints(1.25);

        wordApp.ActiveDocument.DefaultTabStop = CentimetersToPoints(0.8);
    }

    static void Execute(Action action, string description)
    {
        Console.Write(description);
        Stopwatch stopwatch = Stopwatch.StartNew();
        Timer timer = new Timer((state) => Console.Write("."), null, 0, 1000);

        action();

        timer.Dispose();
        stopwatch.Stop();
        Console.WriteLine("done. ({0:f2} secs)", stopwatch.Elapsed.TotalSeconds);
    }

    static float CalcPageWidth()
    {
        var pageWidth =
            wordApp.ActiveDocument.PageSetup.PageWidth
            - wordApp.ActiveDocument.PageSetup.LeftMargin
            - wordApp.ActiveDocument.PageSetup.RightMargin;
        return pageWidth;
    }

    static float CentimetersToPoints(dynamic cm)
    {
        return wordApp.CentimetersToPoints(cm);
    }
}
