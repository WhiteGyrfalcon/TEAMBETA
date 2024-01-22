let items = Array.from(document.querySelectorAll(".main-nav ul li a"));
let svgItems = Array.from(document.querySelectorAll("svg.union"));
for (const item of items) {
    item.addEventListener('click', selectBtn);
}

function selectBtn(e) {
    let remove = svgItems[0].style.display = 'none';
    let svg = e.currentTarget.children[1].children[1];

    let existing = svgItems.find(i => i.style.display === 'block');

    if (existing) {
        existing.style.display = 'none';
    }

    svg.style.display = 'block';
}
