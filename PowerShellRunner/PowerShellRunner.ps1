write-host "Args.Count: "$args.Length
if($args.Length -gt 0) {
	$numOfArgs = $args.Length
	for ($i=0; $i -le $numOfArgs; $i++)
	{
	   write-host $args[$i]
	}
}
write-host "Hit enter to exit..." -ForegroundColor Yellow
$i = read-host