/***************************************************************************
 This script is intended to merge all book chapters into a single HTML page.
 How to use it?
   1) Open the book URL in your Web browser: https://csharp-book.softuni.bg
   2) Open the browser's developer console by pressing [F12]
   3) Paste and execute this JS code.
 It will loadd all book chapters into a single HTML page. This HTML can later
 be converted to other formats (MS Word DOCX, MS Word RTF, ePub, Mobi, PDF)
 using Calibre (https://calibre-ebook.com) or custom propress tool.
****************************************************************************/

// Extract the chapters URLs from the book summary panel
let chapters = [];
$('ul.summary li.chapter a').toArray().forEach(function(item, index) {
  chapters[index] = { url: item.href };
});

// Download the HTML for each book chapter with AJAX request
let chaptersLeft = chapters.length;
for (let chapter of chapters) {
  downloadChapter(chapter);
}

function downloadChapter(chapter) {
  console.log("Loading: " + chapter.url);
  $.get(chapter.url, {}, function(html) {
    chapter.html = html;
    console.log("Loaded: " + chapter.url);
	chaptersLeft--;
	if (chaptersLeft == 0) {
      console.log("All book chapters loaded.");
	  displayAllChapters(chapters);
	}
  });  
}

function displayAllChapters(chapters) {
  $('body').html('<div class="book"><div class="book-body"><div class="body-inner"><div class="page-wrapper"><div class="page-inner"></div></div></div></div></div>');
  for (let chapter of chapters) {
    let chapterHtml = $($.parseHTML(chapter.html));
    let chapterMarkdown = $(chapterHtml.find('section.markdown-section'));
    $('div.page-inner').append(chapterMarkdown);
	console.log(`Chapter ${chapter.url} appended.`);
  }
}
