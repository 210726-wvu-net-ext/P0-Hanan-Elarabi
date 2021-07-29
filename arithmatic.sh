
read -p "Please insert a number" number
if (($number % 2 == 0))
then
echo 'The number is even'
elif (($number % 2 == 1))
then
echo 'The number is odd'
fi