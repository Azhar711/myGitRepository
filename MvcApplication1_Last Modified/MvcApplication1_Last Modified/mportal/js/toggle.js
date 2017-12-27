$(document).ready(function(){
		$(".toggle").hide(); //Hides all .Toggle divs


$('.toggleClick').click(function(){
			var iteration=$(this).data('iteration')||1
			switch ( iteration) {
				case 1:
					$(this).children('.toggle').slideDown()
					$(this).children('.toggleHeader').css('text-decoration', 'underline')
					break;
				
				case 2:
					$(this).children('.toggle').slideUp()
					$(this).closest('.toggleHeader').css('text-decoration', 'none')
					break;
			}
			iteration++;
			if (iteration>2) iteration=1
			$(this).data('iteration',iteration)
		})


$(".toggleClick").click(function() {
	$(this).toggleClass("open");
	});	
	
				
$("a.Insidelink").click(
					function(){
						window.open($(this).attr('href'), '_self');
						}
				);		
				
				$("a.Outsidelink").click(
					function(){
						window.open($(this).attr('href'), '_blank');
						}
				);
				
				$("a.Homelink").click(
					function(){
						window.open($(this).attr('href'), '_parent');
						}
				);
});
