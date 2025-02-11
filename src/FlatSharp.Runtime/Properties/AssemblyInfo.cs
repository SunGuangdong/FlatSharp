﻿/*
 * Copyright 2018 James Courtney
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Runtime.CompilerServices;

#if SIGNED_BUILD

[assembly: InternalsVisibleTo("FlatSharp, PublicKey=0024000004800000940000000602000000240000525341310004000001000100898185ce69dca04430ab296e094cd7eb6c66f5a3cfb0631ef64586fa183f0cb5ca64c47539a3a3c6351a9cf8d976a8d94350af430d5adc10536b3904cc1d6ecaaf3d0cb708aa318c559625f05d3b2d89da1c2bb323bb40e36dcf9245f21c3a4b6793c56ffface5e6e18290afb13c7eac1ea9c7a0c22f289c622bfa7b247d81a2")]
[assembly: InternalsVisibleTo("FlatSharpTests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100898185ce69dca04430ab296e094cd7eb6c66f5a3cfb0631ef64586fa183f0cb5ca64c47539a3a3c6351a9cf8d976a8d94350af430d5adc10536b3904cc1d6ecaaf3d0cb708aa318c559625f05d3b2d89da1c2bb323bb40e36dcf9245f21c3a4b6793c56ffface5e6e18290afb13c7eac1ea9c7a0c22f289c622bfa7b247d81a2")]
[assembly: InternalsVisibleTo("FlatSharpEndToEndTests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100898185ce69dca04430ab296e094cd7eb6c66f5a3cfb0631ef64586fa183f0cb5ca64c47539a3a3c6351a9cf8d976a8d94350af430d5adc10536b3904cc1d6ecaaf3d0cb708aa318c559625f05d3b2d89da1c2bb323bb40e36dcf9245f21c3a4b6793c56ffface5e6e18290afb13c7eac1ea9c7a0c22f289c622bfa7b247d81a2")]
[assembly: InternalsVisibleTo("PoolingTests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100898185ce69dca04430ab296e094cd7eb6c66f5a3cfb0631ef64586fa183f0cb5ca64c47539a3a3c6351a9cf8d976a8d94350af430d5adc10536b3904cc1d6ecaaf3d0cb708aa318c559625f05d3b2d89da1c2bb323bb40e36dcf9245f21c3a4b6793c56ffface5e6e18290afb13c7eac1ea9c7a0c22f289c622bfa7b247d81a2")]
[assembly: InternalsVisibleTo("FlatSharpCompilerTests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100898185ce69dca04430ab296e094cd7eb6c66f5a3cfb0631ef64586fa183f0cb5ca64c47539a3a3c6351a9cf8d976a8d94350af430d5adc10536b3904cc1d6ecaaf3d0cb708aa318c559625f05d3b2d89da1c2bb323bb40e36dcf9245f21c3a4b6793c56ffface5e6e18290afb13c7eac1ea9c7a0c22f289c622bfa7b247d81a2")]
[assembly: InternalsVisibleTo("FlatSharp.Compiler, PublicKey=0024000004800000940000000602000000240000525341310004000001000100898185ce69dca04430ab296e094cd7eb6c66f5a3cfb0631ef64586fa183f0cb5ca64c47539a3a3c6351a9cf8d976a8d94350af430d5adc10536b3904cc1d6ecaaf3d0cb708aa318c559625f05d3b2d89da1c2bb323bb40e36dcf9245f21c3a4b6793c56ffface5e6e18290afb13c7eac1ea9c7a0c22f289c622bfa7b247d81a2")]
[assembly: InternalsVisibleTo("ExperimentalBenchmark, PublicKey=0024000004800000940000000602000000240000525341310004000001000100898185ce69dca04430ab296e094cd7eb6c66f5a3cfb0631ef64586fa183f0cb5ca64c47539a3a3c6351a9cf8d976a8d94350af430d5adc10536b3904cc1d6ecaaf3d0cb708aa318c559625f05d3b2d89da1c2bb323bb40e36dcf9245f21c3a4b6793c56ffface5e6e18290afb13c7eac1ea9c7a0c22f289c622bfa7b247d81a2")]
[assembly: InternalsVisibleTo("Benchmark, PublicKey=0024000004800000940000000602000000240000525341310004000001000100898185ce69dca04430ab296e094cd7eb6c66f5a3cfb0631ef64586fa183f0cb5ca64c47539a3a3c6351a9cf8d976a8d94350af430d5adc10536b3904cc1d6ecaaf3d0cb708aa318c559625f05d3b2d89da1c2bb323bb40e36dcf9245f21c3a4b6793c56ffface5e6e18290afb13c7eac1ea9c7a0c22f289c622bfa7b247d81a2")]

#else

[assembly: InternalsVisibleTo("FlatSharp")]
[assembly: InternalsVisibleTo("FlatSharpTests")]
[assembly: InternalsVisibleTo("FlatSharpCompilerTests")]
[assembly: InternalsVisibleTo("FlatSharpEndToEndTests")]
[assembly: InternalsVisibleTo("PoolingTests")]
[assembly: InternalsVisibleTo("FlatSharp.Compiler")]
[assembly: InternalsVisibleTo("ExperimentalBenchmark")]
[assembly: InternalsVisibleTo("Benchmark")]

#endif