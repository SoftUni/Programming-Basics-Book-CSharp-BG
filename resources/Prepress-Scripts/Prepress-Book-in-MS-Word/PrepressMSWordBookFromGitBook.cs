using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

class PrepressMSWordBookFromGitBook
{
    const string inputFileName =
        @"E:\C# Basics Book\GitHub JS\Programming-Basics-Book-JS-BG\resources\js-html.docx";
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
        Execute(FixParagraphs, "Fixing paragraphs (headings / lists / source code blocks)");
        Execute(FixTables, "Fixing tables");
        Execute(FixImageSizes, "Fixing image sizes");
        Execute(FixWordsLanguage, "Fixing language for individual words");

        stopwatch.Stop();
        wordApp.Visible = true;
        Console.WriteLine("Total time: {0}", stopwatch.Elapsed);
    }

    static void FixWordsLanguage()
    {
        foreach (Range word in wordApp.ActiveDocument.Words)
        {
            string wordText = word.Text.Trim();
            var cyrillicLettersCount = CountCyrillicLetters(wordText);
            if (cyrillicLettersCount == wordText.Length)
            {
                // The word holds Cyrillic letters only --> set Bulgarian language
                word.LanguageID = WdLanguageID.wdBulgarian;
            }
            else
            {
                // The word holds non-Cyrillic letters --> set English language
                word.LanguageID = WdLanguageID.wdEnglishUS;
                bool isCodeIdentifier = IsCodeIdentifier(wordText);
                bool isBracket = wordText == "(" || wordText == ")";
                bool isMonospacedFont = (word.Font.Name == "Consolas");
                if (isCodeIdentifier || isBracket || isMonospacedFont)
                    // Disable the spell checker for code identifiers
                    word.NoProofing = True;
            }
        }

        int CountCyrillicLetters(string word) =>
            word.ToLower().Count(l => l >= 'а' && l <= 'я');

        bool IsCodeIdentifier(string word) =>
            word.Skip(1).Count(l => l >= 'A' && l <= 'Z') > 0;
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
        finder.Font.Name = "Helvetica";
        finder.Replacement.Font.Name = "Lato Light";
        finder.Replacement.Font.Size = 11;
        finder.Execute(Replace: WdReplace.wdReplaceAll);

        finder.ClearFormatting();
        finder.Replacement.ClearFormatting();
        finder.Font.Name = "Segoe UI";
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

    static void FixParagraphs()
    {
        foreach (Paragraph par in wordApp.ActiveDocument.Paragraphs)
        {
            int outlineLevel = (int)par.OutlineLevel;
            if (outlineLevel >= 1 && outlineLevel <= 6)
            {
                // Process headings: Heading 1, Heading 2, ..., Heading 6
                par.set_Style("Heading " + outlineLevel);
            }
            else
            {
                // Process paragraphs
                var parFormat = par.Range.ParagraphFormat;

                if (par.Range.ListFormat.ListType != WdListType.wdListNoNumbering)
                    // Process lists (bullets / numbered list / nested bullets)
                    FormatListParagraph(par, parFormat);
                else if (par.Range.Font.Name == "Consolas")
                    // Process source code blocks
                    FormatSourceCodeParagraph(par, parFormat);
                else
                    // Format normal text paragraphs
                    FormatNormalTextParagraph(parFormat);
            }
        }

        void FormatListParagraph(Paragraph par, ParagraphFormat parFormat)
        {
            parFormat.SpaceBeforeAuto = False;
            parFormat.SpaceBefore = 5;
            parFormat.SpaceAfterAuto = False;
            parFormat.SpaceAfter = 5;
            parFormat.FirstLineIndent = CentimetersToPoints(-0.4);
            var leftIndent = 0.8 * par.Range.ListFormat.ListLevelNumber + 0.1;
            parFormat.LeftIndent = CentimetersToPoints(leftIndent);
            parFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
            parFormat.TabStops.ClearAll();
        }

        void FormatSourceCodeParagraph(Paragraph par, ParagraphFormat parFormat)
        {
            parFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;

            par.Range.NoProofing = True;

            parFormat.SpaceBeforeAuto = False;
            parFormat.SpaceBefore = 0;
            parFormat.SpaceAfterAuto = False;
            parFormat.SpaceAfter = 0;

            par.Borders.DistanceFromTop = 0;
            par.Borders.DistanceFromRight = 0;
            par.Borders.DistanceFromBottom = 0;
            par.Borders.DistanceFromLeft = 0;

            if (par.Range.Tables.Count == 0)
            {
                // The paragraph is not inside a table cell
                par.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
                par.Borders.OutsideLineWidth = WdLineWidth.wdLineWidth600pt;
                par.Borders.OutsideColor = CreateWdColor(247, 247, 247);

                par.Shading.BackgroundPatternColor = CreateWdColor(247, 247, 247);

                parFormat.LeftIndent = CentimetersToPoints(0.4);
                parFormat.RightIndent = CentimetersToPoints(0.4);
            }
        }
    }

    static void FormatNormalTextParagraph(ParagraphFormat parFormat)
    {
        parFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify;
        parFormat.SpaceBeforeAuto = False;
        parFormat.SpaceBefore = 5;
        parFormat.SpaceAfterAuto = False;
        parFormat.SpaceAfter = 5;
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
    
    static void FixPageSizeAndMargins()
    {
        var pageSetup = wordApp.ActiveDocument.PageSetup;
        pageSetup.PageWidth = CentimetersToPoints(17);
        pageSetup.PageHeight = CentimetersToPoints(24);

        pageSetup.MirrorMargins = True;
        pageSetup.LeftMargin = CentimetersToPoints(1.5);
        pageSetup.RightMargin = CentimetersToPoints(1);
        pageSetup.TopMargin = CentimetersToPoints(1);
        pageSetup.BottomMargin = CentimetersToPoints(1);

        pageSetup.HeaderDistance = CentimetersToPoints(1);
        pageSetup.FooterDistance = CentimetersToPoints(1);

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

    static WdColor CreateWdColor(int red, int green, int blue)
    {
        var color = (WdColor)(red + 0x100 * green + 0x10000 * blue);
        return color;
    }
}
