// JavaScript Document
$(document).ready(function() {
	
	//The following places the url of the current page on the end of the share links.	
	$('.ShareLink').each(function(index, element) {
        var href = $(this).attr('href');
		$(this).attr('href', href + window.location.href);
		$(this).css('display', 'inline');
    });
	
	//places current url on sizer links for app to redirect with the correct css sheet.
	$('.SizerLink').each(function(index, element) {
		$(this).css('display', 'inline');
    });
	
	
	// checks for the hide sizer and hide share box query string.
	if (window.location.href.indexOf('?') > -1) {
		var queryStrings = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
		var queryStringValues;
	
		for(var i = 0; i < queryStrings.length; i++)
		{
			queryStringValues = queryStrings[i].split('=');
			
			if(queryStringValues[0].toLowerCase() == 'hideaaa') {
				if(queryStringValues[1].toLowerCase() == 'y') {
					$('.SizerLink').each(function(index, element) {
						$(this).css('display', 'none');
					});
				}		
			}
			
			if(queryStringValues[0].toLowerCase() == 'hidesb') {
				if(queryStringValues[1].toLowerCase() == 'y') {
					$('.ShareLink').each(function(index, element) {
						$(this).css('display', 'none');
					});
					$('.ShareBtn').each(function(index, element) {
						$(this).css('display', 'none');
					});
				}
			}
		}
	}
	
	// 09/30/2013 - changes css file based on sizer choice.
	var sizer = $.cookie('selectedstyle');
	var protocal = document.location.protocol;
	
	if(sizer == 'default') {
		$('#commonCss').attr('href', '/mportal/css/common.css');
	}
	if(sizer == 'medium') {
		$('#commonCss').attr('href', '/mportal/css/common-med.css');
	}
	if(sizer == 'large') {
		$('#commonCss').attr('href', '/mportal/css/common-lg.css');
	}	
	
	$('#googleFonts1').attr('href', protocal + '//fonts.googleapis.com/css?family=Open+Sans:400,400italic,600,600italic,700,700italic,800,800italic');
	$('#googleFonts2').attr('href', protocal + '//fonts.googleapis.com/css?family=Open+Sans:400,400italic,600,600italic,700,700italic,800,800italic');
	
});
