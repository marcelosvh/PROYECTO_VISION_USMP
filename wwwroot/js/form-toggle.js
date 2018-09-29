$(document).ready(function(){ 
	var touch 	= $('#resp-form');
	var barra_menu_desplegar 	= $('.barra_menu_desplegar');
 
	$(touch).on('click', function(e) {
		e.preventDefault();
		barra_menu_desplegar.slideToggle();
	});
	
	$(window).resize(function(){
		var w = $(window).width();
		if(w > 810 && barra_menu_desplegar.is(':hidden')) {
			barra_menu_desplegar.removeAttr('style');
		}
	});

	$('.resp-form').click(function() {
	    $("i", this).toggleClass("fa-minus fa-plus");
	});

	
});