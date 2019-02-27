$TXTFILE = @(Get-Content $args[0])
echo ''>staff.txt
ForEach($TXT in $TXTFILE)
{
    
    $TXT = $TXT.TRIM()
    $TXT = $TXT -replace ' F ', ' Female '
    $TXT = $TXT -replace ' Females ', 'Female'
    $TXT = $TXT -replace ' M ', ' Male '
    $TXT = $TXT -replace ' Males ', 'Male'

    $TXT = $TXT -replace ' \*', ' '
    $TXT = $TXT -replace '\|', ' '
    $TXT = $TXT -replace ' # ', ' '

    $TXT = $TXT -replace '@@', '@'

    $TXT = $TXT -replace '\s+', ' '

    $TXT = $TXT -replace 'Hourly ', 'H '
    $TXT = $TXT -replace 'Yearly ', 'Y '
    $TXT = $TXT -replace 'H \$', ' H $'
    $TXT = $TXT -replace 'Y \$', ' Y $'    
    $TXT = $TXT -replace ' H ', ' Hourly '    
    $TXT = $TXT -replace ' Y ', ' Yearly '   

    $TXT -match "^\S+\s+(\w+)\s+(\w+)\s+([0-9]+\.[0-9]+\.[0-9]+)\s+(\w+)\s+([0-9]+)\s+"
    echo ""
    $Matches[1]
    $Matches[2]
    $Matches[3]
    $Matches[4]
    $Matches[5]
    echo $TXT >>Staff.txt
}