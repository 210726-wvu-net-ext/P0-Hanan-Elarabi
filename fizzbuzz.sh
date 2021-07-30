n=0
while (( $n <= 20 ))
do
if [ $(( n%3 )) -eq 0 ]
then
echo 'Fizz'
elif [ $(( n%5 )) -eq 0 ]
then
echo 'Buzz'
fi
(( n++ ))
done