# MIPS program that reads commands from a file and consumes them
#   Brian Sherman & Nathaniel Leclerc

	 .data
fout:	 .asciiz "C:/Users/Brian/Desktop/Computer Architecture/X-Bot MIPS/commandsend.txt"	# filepath
buffer:  .space 20 #buffer for reading (should contain newline character as well)
	 .text

main:
	# Open file
	li   $v0, 13       # load syscall number
	la   $a0, fout     # load output file name
	li   $a1, 0x0040   # load file for read, delete file on exit
	li   $a2, 0        # ignored; file should exist already
	syscall

	# Read from file
	move $a0, $v0      # load descriptor
	li   $v0, 14       # load syscall number
	la   $a1, buffer   # load buffer
	li   $a2, 18
	syscall
	
	# Close file 
	li   $v0, 16       # load syscall number
	syscall

	# Print to user
	li   $v0, 4
	move $a0, $a1
	syscall

	# Exit program
	li   $v0, 10
	syscall