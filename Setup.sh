#!/bin/bash


# This file is unused and kept for reference
set -e

until /root/.dotnet/tools/dotnet-ef database update --no-build; do
>&2 echo "SQL Server is starting up"
sleep 1
done

>&2 echo "SQL Server is up - executing command"

/root/.dotnet/tools/dotnet-ef database update