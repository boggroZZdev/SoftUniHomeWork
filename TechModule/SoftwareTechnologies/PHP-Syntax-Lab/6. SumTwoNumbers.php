<?php
if (isset($_GET['num1']) && isset($_GET['num2'])){
    $numb1 = intval($_GET['num1']);
    $numb2 = intval($_GET['num2']);
    $sum = $numb1+$numb2;
    echo "<p>$numb1 + $numb2 = $sum</p>";
}?>
<form>
    <div>First number:</div>
    <input type="number" name="num1"/>
    <div>Second Number:</div>
    <input type="number" name="num2"/>
    <div><input type="submit" value="Calculate"/></div>
</form>

