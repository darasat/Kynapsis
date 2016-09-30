
function Eliminar(i){
    document.getElementById("tableid").deleteRow(i);
}

function AgregarFila(){
	
	var numFilas = $('#tableid >tbody >tr').length;	
	numFilas = numFilas + 1;
	
	var tds = "<tr>";
	
	tds += "<td></td>";
	tds += "<td></td>";
	
	tds += "<td class='col-xs-2'>";
	tds +="<button type='button' class='btn btn-primary' data-toggle='modal' data-target='#"+numFilas+"'><div class='fs1' aria-hidden='true' data-icon='&#xe00f;' id='agregar'></div>editar</button>";
	tds +="	<div class='modal fade bs-example-modal-sm' id='"+numFilas+"' tabindex='-1' role='dialog' aria-labelledby='mySmallModalLabel'>";
	tds +="		<div class='modal-dialog'>";
	tds +="			<div class='modal-content'>";
	tds +="				<div class='modal-header'>";
	tds +="					<button type='button' class='close' data-dismiss='modal' aria-label='Close'><span aria-hidden='true'>&times;</span></button>";
	tds +="						<h4 class='modal-title'>Modal title</h4>";
	tds +="				</div>";
	tds +="				<div class='modal-body'>";
	tds +="					<form role='form'>";
	tds +="						<div class='form-group' >";
	tds +="							<label>tipo de usuario</label>";
	tds +="								<input class='form-control' />";
	tds +="						</div>";
	tds +="						<div class='form-group' >";
	tds +="							<label>costo</label>";
	tds +="								<input class='form-control' />";
	tds +="						</div>";
	tds +="					</form>";
	tds +="				</div>";
	tds +="				<div class='modal-footer'>";
	tds +="					<button type='button' class='btn btn-default' data-dismiss='modal'>Close</button>";
	tds +="					<button type='button' class='btn btn-primary'>Save changes</button>";
	tds +="				</div>";
	tds +="			</div>";
	tds +="		</div>";
	tds +="	</div>";
	tds +="</td>";
	tds += "<td class='col-xs-2'>";
	tds +="	<input type='button' value='Eliminar' onclick='Eliminar(this.parentNode.parentNode.rowIndex)' class='btn btn-default'/>";
	tds +="</td>";	
	tds += "</tr>";
														
	$("#tableid").append(tds);
}

