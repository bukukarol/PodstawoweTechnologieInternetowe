// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
var PagesOrder = [
    '/Index',
    '/Warmup',
    '/Warmup/InspectMe',
    '/Warmup/CommandMenu',
    '/CSS',
    '/CSS/StylesPane',
    '/CSS/ComputedPane',
    '/CSS/NavigateDOMTree',
    '/CSS/Animations',
    '/JavaScript',
    '/JavaScript/Console',
    '/JavaScript/Logging',
    '/JavaScript/SourcePanel',
    '/JavaScript/Breakpoints',
    '/End'
];

var Animals = [
    {
        Name: 'Dog',
        Legs: 4,
        Color: 'White',
        Cute: true,
    },
    {
        Name: 'Kat',
        Legs: 4,
        Color: 'Black',
        Cute: true,
    },
    {
        Name: 'Snake',
        Legs: 0,
        Color: 'Green',
        Cute: false,
    }];
var CurrentPage = GetCurrentPage();

function GetCurrentPage() {
    var currentPagePath = window.location.pathname;
    if (currentPagePath === null || currentPagePath === "/") {
        return 0;
    }
    if (currentPagePath.endsWith("/")) {
        var l = currentPagePath.length;
        currentPagePath = currentPagePath.slice(0, l - 1);
    }
    currentPagePath.replace('/', '');
    var result;
    $(PagesOrder).each(function (i, obj) {
        if (obj.toLowerCase() === currentPagePath.toLowerCase()) {
            result = i;
            return;
        }
    });
    return result;
}

function PreviousPage() {
    if (CurrentPage > 0) {
        CurrentPage -= 1;        
    } else {
        CurrentPage = 0;
    }   
    window.location.href = PagesOrder[CurrentPage];
}

function NextPage() {
    var maxPageNr = PagesOrder.length - 1;
    if (CurrentPage < maxPageNr) {
        CurrentPage += 1;
    } else {
        CurrentPage = maxPageNr;
    }    
    window.location.href = PagesOrder[CurrentPage];
}

function Animate() {
    $(".animateElement").removeClass("off");
    $(".animateElement").addClass("on");
}
function StopAnimation() {
    $(".animateElement").addClass("off");
    $(".animateElement").removeClass("on");
}

function TraceExample() {
    GoDeep();
    function GoDeep() {
        EvenDeepa();
        function EvenDeepa() {
            console.trace("Where I am?");
        }
    }
}

function RandomColorForHeader() {
    debugger;
    var s =255;
    var r,g,b,a;
    r = GetRandomInt(s);
    g = GetRandomInt(s);
    b = GetRandomInt(s);
    a = Random().toFixed(1);
    debugger;
    var color = GetRgbaDefinition(r, g, b, a);
    $("h3").css("color", color);
}
function GetRgbaDefinition(r, g, b, a) {
    return 'rgba('+ r + ',' + g +',' + b + ',' + a + ')';
}
function GetRandomInt(max) {
    return RoundToInt(Random() * max);
}

function RoundToInt(number) {
    return Math.round(number);
}
function Random() {
    return Math.random();
}

$(document).ready(function () {
    $("#ChangeColorBtn").click(function () {
        $("h3").css("color", "red");
    });
});

function ChangeFont() {
    document.getElementById("h3").style.fontStyle = "italic";
}