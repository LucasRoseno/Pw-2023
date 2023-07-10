function enviar_dados()
{
	// validando o nome
    if (document.forms[0].TextBox1.value.length < 3)
	{
	    window.alert("Campo NOME não preenchido, por gentileza digite seu NOME");
	    document.forms[0].TextBox1.value="";
	    document.forms[0].TextBox1.focus();
	    return false;
	}
    // validando o e-mail
    if (document.forms[0].TextBox1.value.indexOf('@')==-1 || document.forms[0].TextBox1.value.indexOf('.')==-1)
	{
	    alert("Campo EMAIL não preenchido, por gentileza digite seu EMAIL");
	    document.forms[0].TextBox1.value="";
	    document.forms[0].TextBox1.focus();
	    return false;
	}
    window.parent.location.href = 'Teste.aspx';
    window.alert("Mensagem enviada com sucesso!");
	return true;
}

function somente_numeros(event)
{
    var charCode = (event.which) ? event.which : event.keyCode
    if (charCode > 31 && (charCode < 48 || charCode > 57))
    return false;
    return true;
}


function pegar_valor()
{
    var texto = document.forms[0].TextBox2.value;
    window.alert(texto);
}




