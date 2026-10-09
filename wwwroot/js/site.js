// Dark / light switch (remembered between pages)
(function () {
  var root = document.documentElement;
  var toggle = document.getElementById("themeToggle");
  function sync() { toggle.setAttribute("aria-checked", root.getAttribute("data-theme") === "dark"); }
  sync();
  toggle.addEventListener("click", function () {
    var next = root.getAttribute("data-theme") === "dark" ? "light" : "dark";
    root.setAttribute("data-theme", next);
    try { localStorage.setItem("theme", next); } catch (e) { }
    sync();
  });
})();
