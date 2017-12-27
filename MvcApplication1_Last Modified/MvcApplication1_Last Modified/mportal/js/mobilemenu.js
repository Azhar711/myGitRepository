jQuery(document).ready(function($){

/* hide menus on pageload */
$(".mobileMenu .mobileNav .toggleMenu").hide(0);

/* dynamically create the mobile menu */

/* create the variables from menus on the page*/
var qlHeader = " ";
var qlLinks = " ";
var piHeader = " ";
var piLinks = " ";
var menuLinks = " ";
var topLinks = " ";

/* check if menus exist and change variable */
 if(document.getElementById("LeftNav") != null) {
	var qlHeader = "<div class='quickLinks'><span class='menuItem'>"+ $("#LeftNav > div > h1").html() +"</span>";
var qlLinks = "<ul class='subCategories'>"+ $("#LeftNav > div > ul").html() +"</ul></div>";
 } 
 
 if(document.getElementById("PersonalInfo") != null)  {
	 var piHeader = "<div class='personalInfo'><span class='menuItem'>"+ $("#PersonalInfo > div > h1 > a").html() +"</span>";
	 var piLinks = "<div class='subCategories'>"+ $("#PersonalInfo > #PersonalInfoShadow").html() +"</div></div>";
 } 
 
 if(document.getElementById("MenuRight") != null)  {
	 if($("#MenuRight").find("ul").length > 0)  {
	 var menuLinks = $("#MenuRight > ul").html();
	 }
 } 
 
 if(document.getElementById("TopNav") != null)  {
	 var topLinks = $("#TopNav > ul").html(); 
 }
 
 /*build the mobile menu after the header*/
 $("#Header").after("<div class='mobileMenu'><div class='mobileNav'><div class='toggleMenu'>"+ qlHeader + qlLinks +" "+ piHeader + piLinks +"<div class='topLinks'>"+ menuLinks + topLinks + "</div></div></div>");
 
 $(".personalInfo > div > h1").remove();
 $(".topLinks li").contents().unwrap();


$(function(){
       $(".mobileNav a").each(function(){
               if ($(this).attr("href") == window.location.pathname){
                       $(this).parent().addClass("current");
					   $(this).parents(".subCategories").show(0);
					   $(this).parents(".subCategories").parent().addClass("active");
               }
       });
});

/* make sublinks clickable */
$('.mobileNav > div > div > ul li').delegate('a', 'click', function(e) {
    e.stopImmediatePropagation();
});

$('.mobileNav > div > div').delegate('a', 'click', function(e) {
    e.stopImmediatePropagation();
});


	/* prepend menu icon */
	$('.mobileNav').prepend('<div id="menuIcon"><span class="title">Menu</span> <div class="menuBtn"> <span></span> <span></span> <span></span> </div></div> ');
	
	/* toggle nav */
	$("#menuIcon").on("click", function(){
		$(".mobileNav > .toggleMenu").slideToggle();
		$(this).toggleClass("active");
	});
	
	/* toggle sub nav */
	$(".mobileNav > .toggleMenu > div").on("click", function(){
		$(this).siblings().children(".subCategories").slideUp();
		$(this).siblings().removeClass("active");
		$(this).children(".subCategories").slideToggle();
		$(this).toggleClass("active");
	});
	

	/*Share Links */
$(function(){
       $(".shareMenu a").each(function(){
               if ($(this).attr("href") == window.location.pathname){
                       $(this).parent().addClass("current");
					   $(this).parents(".subCategories").show(0);
					   $(this).parents(".subCategories").parent().addClass("active");
               }
       });
});

	/* prepend share menu icon */
	$('.shareMenu').prepend('<div class="shareIcon"><div class="shareBtn"> </div> <span class="title">Share</span> </div> ');
	
	/* toggle share nav */
	$(".shareIcon").on("click", function(){
		$(".shareMenu .topCategories").slideToggle();
		$(this).toggleClass("active");
	});

});



// Run on window load instead of on DOM Ready in case images or other scripts affect element widths
$(window).on('load', function() {
    // Check all tables. You may need to be more restrictive.
    $('table table').each(function() {
        var element = $(this);
        // Create the wrapper element
        var scrollWrapper = $('<div />', {
            'class': 'scrollable',
            'html': '<div />' // The inner div is needed for styling
        }).insertBefore(element);
        // Store a reference to the wrapper element
        element.data('scrollWrapper', scrollWrapper);
        // Move the scrollable element inside the wrapper element
        element.appendTo(scrollWrapper.find('div'));
        // Check if the element is wider than its parent and thus needs to be scrollable
        if (element.outerWidth() > element.parent().outerWidth()) {
            element.data('scrollWrapper').addClass('has-scroll');
        }
        // When the viewport size is changed, check again if the element needs to be scrollable
        $(window).on('resize orientationchange', function() {
            if (element.outerWidth() > element.parent().outerWidth()) {
                element.data('scrollWrapper').addClass('has-scroll');
            } else {
                element.data('scrollWrapper').removeClass('has-scroll');
            }
        });
    });
});
