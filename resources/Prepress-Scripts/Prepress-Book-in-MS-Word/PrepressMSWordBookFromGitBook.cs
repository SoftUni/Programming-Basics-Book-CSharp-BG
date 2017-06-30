using Microsoft.Office.Interop.Word;
using System;
using System.Diagnostics;
using System.Threading;

class PrepressMSWordBookFromGitBook
{
    const string inputFileName =
        @"C:\Software-University\Programming-Basics-Book-CSharp-BG\resources\Prepress\chapter4.docx";
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
        Execute(FixDocumentLanguage, "Fixing document language");
        Execute(FixHeadings, "Fixing headings");
        Execute(FixImageSizes, "Fixing image sizes");

        stopwatch.Stop();
        wordApp.Visible = true;
        wordApp.ScreenUpdating = true;
        Console.WriteLine("Total time: {0}", stopwatch.Elapsed);
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

    static void StartMSWord()
    {
        wordApp = new Application();
        wordApp.Visible = true;
    }

    static void OpenBookWordFile()
    {
        wordApp.Documents.Open(inputFileName);
    }

    static void FixHeadings()
    {
        var docStyles = wordApp.ActiveDocument.Styles;
        var finder = wordApp.Selection.Find;
        FixHeading(WdOutlineLevel.wdOutlineLevel1, "Heading 1");
        FixHeading(WdOutlineLevel.wdOutlineLevel2, "Heading 2");
        FixHeading(WdOutlineLevel.wdOutlineLevel3, "Heading 3");
        FixHeading(WdOutlineLevel.wdOutlineLevel4, "Heading 4");
        FixHeading(WdOutlineLevel.wdOutlineLevel5, "Heading 5");
        FixHeading(WdOutlineLevel.wdOutlineLevel6, "Heading 6");

        void FixHeading(WdOutlineLevel outlineLevel, string headingName)
        {
            finder.ClearFormatting();
            finder.ParagraphFormat.OutlineLevel = outlineLevel;
            finder.Replacement.ClearFormatting();
            finder.Replacement.set_Style(docStyles[headingName]);
            finder.Execute(Replace: WdReplace.wdReplaceAll);
        }
    }

    static void FixImageSizes()
    {
        var pageWidth =
            wordApp.ActiveDocument.PageSetup.PageWidth
            - wordApp.ActiveDocument.PageSetup.LeftMargin
            - wordApp.ActiveDocument.PageSetup.RightMargin;

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
    }

    static float CentimetersToPoints(dynamic cm)
    {
        return wordApp.CentimetersToPoints(cm);
    }
}
