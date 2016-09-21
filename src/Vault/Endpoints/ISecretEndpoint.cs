﻿using System.Threading;
using System.Threading.Tasks;

namespace Vault.Endpoints
{
    public interface ISecretEndpoint
    {
        Task Delete(string path);
        Task Delete(string path, CancellationToken ct);
        Task<Secret<TData>> List<TData>(string path);
        Task<Secret<TData>> List<TData>(string path, CancellationToken ct);
        Task<Secret<TData>> Read<TData>(string path);
        Task<Secret<TData>> Read<TData>(string path, CancellationToken ct);
        Task<Secret<TData>> Unwrap<TData>(string unwrappingToken);
        Task<Secret<TData>> Unwrap<TData>(string unwrappingToken, CancellationToken ct);
        Task Write<TParameters>(string path, TParameters data);
        Task Write<TParameters>(string path, TParameters data, CancellationToken ct);
    }
}