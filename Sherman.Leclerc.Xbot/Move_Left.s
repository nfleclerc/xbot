# MIPS program that writes commands to a new file to be sent to a robot's processor
#   Brian Sherman & Nathaniel Leclerc

	 .data
fout:	 .asciiz "C:/Users/Brian/Desktop/Computer Architecture/X-Bot MIPS/commandsend.txt"	#filename for output
command: .asciiz "Command_Move_Left\n"
print:	 .asciiz "Move left command created.\n"
	 .text

main:
	# Open file
	li   $v0, 13       # load syscall number
	la   $a0, fout     # load output file name
	li   $a1, 0x010A   # write to end of file
	li   $a2, 0x0180   # allow read & write of a created file
	syscall

	# Write to file
	move $a0, $v0	   # load descriptor
	li   $v0, 15       # load syscall number
	la   $a1, command  # load command
	li   $a2, 18
	syscall
	
	# Close file 
	li   $v0, 16       # load syscall number
	syscall

	# Print to user
	li   $v0, 4
	la   $a0, print
	syscall

	# Exit program
	li   $v0, 10
	syscall