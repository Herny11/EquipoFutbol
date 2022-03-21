$(function () {


	

	$("#btnAbreModal").click(function () {
		/**/

		$.ajax({
			url: "/Futbolistas/Nuevo",
			async: true,
			success: function (res) {

				$("<div class= 'modal fade' id='modalFutbol'></div>").prependTo(".container");
				$("#modalFutbol").modal("show").html(res);

				cargaPosicion();
				

				$("#btnCerrar").click(function () {
					$("#modalFutbol").remove();
					$(".modal-backdrop").removeClass("show").addClass("hide");
					$(".modal-backdrop").remove();
				});

			},
			error: function () {

			}
		})
	});
	$("[id^=btnEditar_]").click(function () {

		var id = $(this).attr("id").replace("btnEditar_", " ");
		$.ajax({
			type: "POST",
			url: "/Futbolistas/EditarView",
			data: { FutbolistasID: id },
			async: true,
			success: function (res) {
				$("<div class='modal fade' id='modalEditaFutbolista'></div>").prependTo(".container");
				$("#modalEditaFutbolista").modal("show").html(res);
				cargaPosicion();
				$("#btcCerrarEditar").click(function () {
					$("#modalEditaFutbolista").remove();
					$(".modal-backdrop").removeClass("show").addClass("hide");
					$(".modal-backdrop").remove();
				})
			},
			error: function () {
			}
		})
	});
	$("[id^=btnEliminar_]").click(function () {
		var id = $(this).attr("id").replace("btnEliminar_", "");

		if (confirm("Estas seguro de querer eliminar el registro?")) {
			$.ajax({
				type: "POST",
				url: "/Futbolistas/Eliminar",
				data: { FutbolistasID: id },
				async: true,
				success: function (res) {
					if (res.status) {
						alert("Registro eliminado")

						setTimeout(() => {
							location.href = "/Futbolistas/"
						}, 1000)
					}
				}

			});

		}
	});
});
function cargaPosicion() {
	$.ajax({
		type: "GET",
		url: "/Futbolistas/GetPosicion",
		async: true,
		success: function (res) {
			var combo = $("#dropPosicion");
			$("<option value='0'>Seleccione una opcion </option >").prependTo(combo);
			$.each(res, function (index, data) {
				/*console.log("index: " + index + "data: " + data);*/
				$("<option value='" + data.posicionID + "'>" + data.posicion + " </option > ").appendTo(combo);
			})
		},
		error: function () {

		}
	});
}
function validaCampo() {
	var validate = true;

	if ($("[id^=Nombres]").val().trim().length == 0) {
		$(".invalid-name").fadeIn();
		$("[id^=Nombres]").addClass("borde-rojo");
		validate = false;
	} else {
		$(".invalid-name").fadeOut();
		$("[id^=Nombres]").removeClass("borde-rojo");
		
	}

	if ($("[id^=Apellidos]").val().trim().length == 0) {
		$(".last_name_validation").fadeIn();
		$("[id^=Apellidos]").addClass("borde-rojo");
		validate = false;
	} else {
		$(".last_name_validation").fadeOut();
		$("[id^=Apellidos]").removeClass("borde-rojo");
	}

	if ($("[id^=Edad]").val().trim().length == 0 ) {
		$(".edad_validation").fadeIn();
		$("[id^=Edad]").addClass("borde-rojo");

		validate = false;
	}
	else {
		$(".edad_validation").fadeOut();
		$("[id^=Edad]").removeClass("borde-rojo");

	}

	
	return validate;
}