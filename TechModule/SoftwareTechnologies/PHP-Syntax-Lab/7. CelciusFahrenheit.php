<?php
function celciusToFahrenheit($celsius)
{
    return $celsius * 1.8 + 32;
}

function fahrenheitToCelsius($fahrenheit)
{
    return ($fahrenheit - 32) / 1.8;
}
$msgAfterFahrenheit = "";
$msgAfterCelsius = "";
$celsius = "";
$fahrenheit= "";
if (isset($_GET['fahrenheit'])) {
    $celsius = round(fahrenheitToCelsius(floatval($_GET['fahrenheit'])), 2);
    $fahrenheit = $_GET['fahrenheit'];
    $msgAfterFahrenheit = "$fahrenheit &deg;F = $celsius &deg;C";
}
if (isset($_GET['celsius'])) {
    $fahrenheit = round(celciusToFahrenheit(floatval($_GET['celsius'])), 2);
    $celsius = $_GET['celsius'];
    $msgAfterCelsius = "$celsius &deg;C = $fahrenheit &deg;F";
}

?>

    <form>
        <span>Celsius:</span>
        <input type="text" name="celsius" />
        <input type="submit" value="Convert"/>
        <?= $msgAfterCelsius ?>
    </form>
    <form>
        <span>Fahrenheit:</span>
        <input type="text" name="fahrenheit"/>
        <input type="submit" value="Convert"/>
        <?= $msgAfterFahrenheit?>
</form>
