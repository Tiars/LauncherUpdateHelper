# Generic_SWGEmu_Launcher
Launcher update helper

While the launcher can download a new copy of itself it
can not copy the new file over itself.

So when the launcer sees that it needs to update itself it will
download the file to a temporary name and then invoke this helper
file.

The sole purpose of this helper file is to tell the user that
the launcher is being updated and to move the temporary copy
of the launcher over the old launcher. It then runs the new version
of the launcher and exits.