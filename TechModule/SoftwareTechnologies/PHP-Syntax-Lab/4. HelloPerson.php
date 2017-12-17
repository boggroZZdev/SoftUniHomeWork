<?php
if (isset($_GET["name"])){
    $name = $_GET["name"];
    echo "Hello, <b>$name</b>";
}else{
?>
<form>
    Name: <input type="text" name="name"/>
    <input type="submit" value="Submit">
</form>
<?php } ?>