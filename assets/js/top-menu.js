gitbook.events.bind("page.change", function() {
    let doc = $('section.markdown-section');
    let topMenu = $(`
        <span class="topnav">
            <a class="logobox" target="_blank" href="https://softuni.bg"><img class="logo" src="/assets/software-university-logo.svg" alt="logo"></a>
            <a target="_blank" href="https://softuni.bg/apply">Стани програмист</a>
            <a target="_blank" href="https://www.youtube.com/c/SoftuniBg">СофтУни @ YouTube</a>
            <a target="_blank" href="https://introprogramming.info">Книгите на Наков</a>
        </span>
    `);
    doc.prepend(topMenu);
});
