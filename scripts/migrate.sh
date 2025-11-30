#!/usr/bin/env bash
set -euo pipefail

PROJECT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
cd "$PROJECT_DIR"

dotnet ef database update \
  --project src/MarkMobileMechanic.Infrastructure/MarkMobileMechanic.Infrastructure.csproj \
  --startup-project src/MarkMobileMechanic.Api/MarkMobileMechanic.Api.csproj "$@"
