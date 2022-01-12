echo "Enter a file name"
read filename
echo "touch $filename"
echo "add ./$filename"
echo "Enter a commit message"
read cmess
echo "commit ./$filename -m $cmess"
echo "push ./$filename"
