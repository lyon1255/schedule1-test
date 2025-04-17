using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200007E RID: 126
	public static class Consts : Il2CppSystem.Object
	{
		// Token: 0x0600093A RID: 2362 RVA: 0x00006FBC File Offset: 0x000051BC
		// Note: this type is marked as 'beforefieldinit'.
		static Consts()
		{
			Il2CppClassPointerStore<Consts>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "Consts");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts>.NativeClassPtr);
			Consts.NativeFieldInfoPtr_PluginFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "PluginFolder");
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00006FF5 File Offset: 0x000051F5
		public Consts(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x0008CDB4 File Offset: 0x0008AFB4
		// (set) Token: 0x0600093D RID: 2365 RVA: 0x00006FFE File Offset: 0x000051FE
		public unsafe static string PluginFolder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_PluginFolder, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_PluginFolder, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeFieldInfoPtr_PluginFolder;

		// Token: 0x0200080D RID: 2061
		public static class Help : Il2CppSystem.Object
		{
			// Token: 0x0600BD09 RID: 48393 RVA: 0x002E915C File Offset: 0x002E735C
			// Note: this type is marked as 'beforefieldinit'.
			static Help()
			{
				Il2CppClassPointerStore<Consts.Help>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "Help");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr);
				Consts.Help.NativeFieldInfoPtr_UrlBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "UrlBase");
				Consts.Help.NativeFieldInfoPtr_UrlSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "UrlSuffix");
				Consts.Help.NativeFieldInfoPtr_UrlDustParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "UrlDustParticles");
				Consts.Help.NativeFieldInfoPtr_UrlTriggerZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "UrlTriggerZone");
				Consts.Help.NativeFieldInfoPtr_UrlEffectFlicker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "UrlEffectFlicker");
				Consts.Help.NativeFieldInfoPtr_UrlEffectPulse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "UrlEffectPulse");
				Consts.Help.NativeFieldInfoPtr_UrlEffectFromProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "UrlEffectFromProfile");
				Consts.Help.NativeFieldInfoPtr_UrlConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "UrlConfig");
			}

			// Token: 0x0600BD0A RID: 48394 RVA: 0x0005C886 File Offset: 0x0005AA86
			public Help(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003A9B RID: 15003
			// (get) Token: 0x0600BD0B RID: 48395 RVA: 0x002E9228 File Offset: 0x002E7428
			// (set) Token: 0x0600BD0C RID: 48396 RVA: 0x0005C88F File Offset: 0x0005AA8F
			public unsafe static string UrlBase
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Help.NativeFieldInfoPtr_UrlBase, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Help.NativeFieldInfoPtr_UrlBase, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003A9C RID: 15004
			// (get) Token: 0x0600BD0D RID: 48397 RVA: 0x002E9248 File Offset: 0x002E7448
			// (set) Token: 0x0600BD0E RID: 48398 RVA: 0x0005C8A1 File Offset: 0x0005AAA1
			public unsafe static string UrlSuffix
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Help.NativeFieldInfoPtr_UrlSuffix, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Help.NativeFieldInfoPtr_UrlSuffix, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003A9D RID: 15005
			// (get) Token: 0x0600BD0F RID: 48399 RVA: 0x002E9268 File Offset: 0x002E7468
			// (set) Token: 0x0600BD10 RID: 48400 RVA: 0x0005C8B3 File Offset: 0x0005AAB3
			public unsafe static string UrlDustParticles
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Help.NativeFieldInfoPtr_UrlDustParticles, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Help.NativeFieldInfoPtr_UrlDustParticles, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003A9E RID: 15006
			// (get) Token: 0x0600BD11 RID: 48401 RVA: 0x002E9288 File Offset: 0x002E7488
			// (set) Token: 0x0600BD12 RID: 48402 RVA: 0x0005C8C5 File Offset: 0x0005AAC5
			public unsafe static string UrlTriggerZone
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Help.NativeFieldInfoPtr_UrlTriggerZone, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Help.NativeFieldInfoPtr_UrlTriggerZone, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003A9F RID: 15007
			// (get) Token: 0x0600BD13 RID: 48403 RVA: 0x002E92A8 File Offset: 0x002E74A8
			// (set) Token: 0x0600BD14 RID: 48404 RVA: 0x0005C8D7 File Offset: 0x0005AAD7
			public unsafe static string UrlEffectFlicker
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Help.NativeFieldInfoPtr_UrlEffectFlicker, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Help.NativeFieldInfoPtr_UrlEffectFlicker, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003AA0 RID: 15008
			// (get) Token: 0x0600BD15 RID: 48405 RVA: 0x002E92C8 File Offset: 0x002E74C8
			// (set) Token: 0x0600BD16 RID: 48406 RVA: 0x0005C8E9 File Offset: 0x0005AAE9
			public unsafe static string UrlEffectPulse
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Help.NativeFieldInfoPtr_UrlEffectPulse, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Help.NativeFieldInfoPtr_UrlEffectPulse, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003AA1 RID: 15009
			// (get) Token: 0x0600BD17 RID: 48407 RVA: 0x002E92E8 File Offset: 0x002E74E8
			// (set) Token: 0x0600BD18 RID: 48408 RVA: 0x0005C8FB File Offset: 0x0005AAFB
			public unsafe static string UrlEffectFromProfile
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Help.NativeFieldInfoPtr_UrlEffectFromProfile, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Help.NativeFieldInfoPtr_UrlEffectFromProfile, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003AA2 RID: 15010
			// (get) Token: 0x0600BD19 RID: 48409 RVA: 0x002E9308 File Offset: 0x002E7508
			// (set) Token: 0x0600BD1A RID: 48410 RVA: 0x0005C90D File Offset: 0x0005AB0D
			public unsafe static string UrlConfig
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Help.NativeFieldInfoPtr_UrlConfig, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Help.NativeFieldInfoPtr_UrlConfig, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008019 RID: 32793
			private static readonly IntPtr NativeFieldInfoPtr_UrlBase;

			// Token: 0x0400801A RID: 32794
			private static readonly IntPtr NativeFieldInfoPtr_UrlSuffix;

			// Token: 0x0400801B RID: 32795
			private static readonly IntPtr NativeFieldInfoPtr_UrlDustParticles;

			// Token: 0x0400801C RID: 32796
			private static readonly IntPtr NativeFieldInfoPtr_UrlTriggerZone;

			// Token: 0x0400801D RID: 32797
			private static readonly IntPtr NativeFieldInfoPtr_UrlEffectFlicker;

			// Token: 0x0400801E RID: 32798
			private static readonly IntPtr NativeFieldInfoPtr_UrlEffectPulse;

			// Token: 0x0400801F RID: 32799
			private static readonly IntPtr NativeFieldInfoPtr_UrlEffectFromProfile;

			// Token: 0x04008020 RID: 32800
			private static readonly IntPtr NativeFieldInfoPtr_UrlConfig;

			// Token: 0x02000C1E RID: 3102
			public static class SD : Il2CppSystem.Object
			{
				// Token: 0x0600E0AF RID: 57519 RVA: 0x0034DE68 File Offset: 0x0034C068
				// Note: this type is marked as 'beforefieldinit'.
				static SD()
				{
					Il2CppClassPointerStore<Consts.Help.SD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "SD");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Help.SD>.NativeClassPtr);
					Consts.Help.SD.NativeFieldInfoPtr_UrlBeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help.SD>.NativeClassPtr, "UrlBeam");
					Consts.Help.SD.NativeFieldInfoPtr_UrlDynamicOcclusionRaycasting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help.SD>.NativeClassPtr, "UrlDynamicOcclusionRaycasting");
					Consts.Help.SD.NativeFieldInfoPtr_UrlDynamicOcclusionDepthBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help.SD>.NativeClassPtr, "UrlDynamicOcclusionDepthBuffer");
					Consts.Help.SD.NativeFieldInfoPtr_UrlSkewingHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help.SD>.NativeClassPtr, "UrlSkewingHandle");
				}

				// Token: 0x0600E0B0 RID: 57520 RVA: 0x0006D8C8 File Offset: 0x0006BAC8
				public SD(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004593 RID: 17811
				// (get) Token: 0x0600E0B1 RID: 57521 RVA: 0x0034DEE4 File Offset: 0x0034C0E4
				// (set) Token: 0x0600E0B2 RID: 57522 RVA: 0x0006D8D1 File Offset: 0x0006BAD1
				public unsafe static string UrlBeam
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Help.SD.NativeFieldInfoPtr_UrlBeam, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Help.SD.NativeFieldInfoPtr_UrlBeam, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17004594 RID: 17812
				// (get) Token: 0x0600E0B3 RID: 57523 RVA: 0x0034DF04 File Offset: 0x0034C104
				// (set) Token: 0x0600E0B4 RID: 57524 RVA: 0x0006D8E3 File Offset: 0x0006BAE3
				public unsafe static string UrlDynamicOcclusionRaycasting
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Help.SD.NativeFieldInfoPtr_UrlDynamicOcclusionRaycasting, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Help.SD.NativeFieldInfoPtr_UrlDynamicOcclusionRaycasting, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17004595 RID: 17813
				// (get) Token: 0x0600E0B5 RID: 57525 RVA: 0x0034DF24 File Offset: 0x0034C124
				// (set) Token: 0x0600E0B6 RID: 57526 RVA: 0x0006D8F5 File Offset: 0x0006BAF5
				public unsafe static string UrlDynamicOcclusionDepthBuffer
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Help.SD.NativeFieldInfoPtr_UrlDynamicOcclusionDepthBuffer, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Help.SD.NativeFieldInfoPtr_UrlDynamicOcclusionDepthBuffer, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17004596 RID: 17814
				// (get) Token: 0x0600E0B7 RID: 57527 RVA: 0x0034DF44 File Offset: 0x0034C144
				// (set) Token: 0x0600E0B8 RID: 57528 RVA: 0x0006D907 File Offset: 0x0006BB07
				public unsafe static string UrlSkewingHandle
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Help.SD.NativeFieldInfoPtr_UrlSkewingHandle, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Help.SD.NativeFieldInfoPtr_UrlSkewingHandle, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x0400966C RID: 38508
				private static readonly IntPtr NativeFieldInfoPtr_UrlBeam;

				// Token: 0x0400966D RID: 38509
				private static readonly IntPtr NativeFieldInfoPtr_UrlDynamicOcclusionRaycasting;

				// Token: 0x0400966E RID: 38510
				private static readonly IntPtr NativeFieldInfoPtr_UrlDynamicOcclusionDepthBuffer;

				// Token: 0x0400966F RID: 38511
				private static readonly IntPtr NativeFieldInfoPtr_UrlSkewingHandle;
			}

			// Token: 0x02000C1F RID: 3103
			public static class HD : Il2CppSystem.Object
			{
				// Token: 0x0600E0B9 RID: 57529 RVA: 0x0034DF64 File Offset: 0x0034C164
				// Note: this type is marked as 'beforefieldinit'.
				static HD()
				{
					Il2CppClassPointerStore<Consts.Help.HD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "HD");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Help.HD>.NativeClassPtr);
					Consts.Help.HD.NativeFieldInfoPtr_UrlBeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help.HD>.NativeClassPtr, "UrlBeam");
					Consts.Help.HD.NativeFieldInfoPtr_UrlShadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help.HD>.NativeClassPtr, "UrlShadow");
					Consts.Help.HD.NativeFieldInfoPtr_UrlCookie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help.HD>.NativeClassPtr, "UrlCookie");
					Consts.Help.HD.NativeFieldInfoPtr_UrlTrackRealtimeChangesOnLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help.HD>.NativeClassPtr, "UrlTrackRealtimeChangesOnLight");
				}

				// Token: 0x0600E0BA RID: 57530 RVA: 0x0006D919 File Offset: 0x0006BB19
				public HD(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004597 RID: 17815
				// (get) Token: 0x0600E0BB RID: 57531 RVA: 0x0034DFE0 File Offset: 0x0034C1E0
				// (set) Token: 0x0600E0BC RID: 57532 RVA: 0x0006D922 File Offset: 0x0006BB22
				public unsafe static string UrlBeam
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Help.HD.NativeFieldInfoPtr_UrlBeam, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Help.HD.NativeFieldInfoPtr_UrlBeam, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17004598 RID: 17816
				// (get) Token: 0x0600E0BD RID: 57533 RVA: 0x0034E000 File Offset: 0x0034C200
				// (set) Token: 0x0600E0BE RID: 57534 RVA: 0x0006D934 File Offset: 0x0006BB34
				public unsafe static string UrlShadow
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Help.HD.NativeFieldInfoPtr_UrlShadow, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Help.HD.NativeFieldInfoPtr_UrlShadow, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17004599 RID: 17817
				// (get) Token: 0x0600E0BF RID: 57535 RVA: 0x0034E020 File Offset: 0x0034C220
				// (set) Token: 0x0600E0C0 RID: 57536 RVA: 0x0006D946 File Offset: 0x0006BB46
				public unsafe static string UrlCookie
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Help.HD.NativeFieldInfoPtr_UrlCookie, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Help.HD.NativeFieldInfoPtr_UrlCookie, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x1700459A RID: 17818
				// (get) Token: 0x0600E0C1 RID: 57537 RVA: 0x0034E040 File Offset: 0x0034C240
				// (set) Token: 0x0600E0C2 RID: 57538 RVA: 0x0006D958 File Offset: 0x0006BB58
				public unsafe static string UrlTrackRealtimeChangesOnLight
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Help.HD.NativeFieldInfoPtr_UrlTrackRealtimeChangesOnLight, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Help.HD.NativeFieldInfoPtr_UrlTrackRealtimeChangesOnLight, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x04009670 RID: 38512
				private static readonly IntPtr NativeFieldInfoPtr_UrlBeam;

				// Token: 0x04009671 RID: 38513
				private static readonly IntPtr NativeFieldInfoPtr_UrlShadow;

				// Token: 0x04009672 RID: 38514
				private static readonly IntPtr NativeFieldInfoPtr_UrlCookie;

				// Token: 0x04009673 RID: 38515
				private static readonly IntPtr NativeFieldInfoPtr_UrlTrackRealtimeChangesOnLight;
			}
		}

		// Token: 0x0200080E RID: 2062
		public static class Internal : Il2CppSystem.Object
		{
			// Token: 0x0600BD1B RID: 48411 RVA: 0x002E9328 File Offset: 0x002E7528
			// Note: this type is marked as 'beforefieldinit'.
			static Internal()
			{
				Il2CppClassPointerStore<Consts.Internal>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "Internal");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Internal>.NativeClassPtr);
				Consts.Internal.NativeFieldInfoPtr_ProceduralObjectsVisibleInEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Internal>.NativeClassPtr, "ProceduralObjectsVisibleInEditor");
				Consts.Internal.NativeMethodInfoPtr_get_ProceduralObjectsHideFlags_Public_Static_get_HideFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Consts.Internal>.NativeClassPtr, 100664272);
			}

			// Token: 0x17003AA4 RID: 15012
			// (get) Token: 0x0600BD1C RID: 48412 RVA: 0x002E937C File Offset: 0x002E757C
			public unsafe static HideFlags ProceduralObjectsHideFlags
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 80028, RefRangeEnd = 80034, XrefRangeStart = 80024, XrefRangeEnd = 80028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Consts.Internal.NativeMethodInfoPtr_get_ProceduralObjectsHideFlags_Public_Static_get_HideFlags_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BD1D RID: 48413 RVA: 0x0005C91F File Offset: 0x0005AB1F
			public Internal(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003AA3 RID: 15011
			// (get) Token: 0x0600BD1E RID: 48414 RVA: 0x002E93AC File Offset: 0x002E75AC
			// (set) Token: 0x0600BD1F RID: 48415 RVA: 0x0005C928 File Offset: 0x0005AB28
			public unsafe static bool ProceduralObjectsVisibleInEditor
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Internal.NativeFieldInfoPtr_ProceduralObjectsVisibleInEditor, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Internal.NativeFieldInfoPtr_ProceduralObjectsVisibleInEditor, (void*)(&value));
				}
			}

			// Token: 0x04008021 RID: 32801
			private static readonly IntPtr NativeFieldInfoPtr_ProceduralObjectsVisibleInEditor;

			// Token: 0x04008022 RID: 32802
			private static readonly IntPtr NativeMethodInfoPtr_get_ProceduralObjectsHideFlags_Public_Static_get_HideFlags_0;
		}

		// Token: 0x0200080F RID: 2063
		public static class Beam : Il2CppSystem.Object
		{
			// Token: 0x0600BD20 RID: 48416 RVA: 0x002E93C8 File Offset: 0x002E75C8
			// Note: this type is marked as 'beforefieldinit'.
			static Beam()
			{
				Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "Beam");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr);
				Consts.Beam.NativeFieldInfoPtr_FlatColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "FlatColor");
				Consts.Beam.NativeFieldInfoPtr_ColorModeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "ColorModeDefault");
				Consts.Beam.NativeFieldInfoPtr_MultiplierDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "MultiplierDefault");
				Consts.Beam.NativeFieldInfoPtr_MultiplierMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "MultiplierMin");
				Consts.Beam.NativeFieldInfoPtr_IntensityDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "IntensityDefault");
				Consts.Beam.NativeFieldInfoPtr_IntensityMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "IntensityMin");
				Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "HDRPExposureWeightDefault");
				Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "HDRPExposureWeightMin");
				Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "HDRPExposureWeightMax");
				Consts.Beam.NativeFieldInfoPtr_SpotAngleDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "SpotAngleDefault");
				Consts.Beam.NativeFieldInfoPtr_SpotAngleMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "SpotAngleMin");
				Consts.Beam.NativeFieldInfoPtr_SpotAngleMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "SpotAngleMax");
				Consts.Beam.NativeFieldInfoPtr_ConeRadiusStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "ConeRadiusStart");
				Consts.Beam.NativeFieldInfoPtr_GeomMeshType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "GeomMeshType");
				Consts.Beam.NativeFieldInfoPtr_GeomSidesDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "GeomSidesDefault");
				Consts.Beam.NativeFieldInfoPtr_GeomSidesMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "GeomSidesMin");
				Consts.Beam.NativeFieldInfoPtr_GeomSidesMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "GeomSidesMax");
				Consts.Beam.NativeFieldInfoPtr_GeomSegmentsDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "GeomSegmentsDefault");
				Consts.Beam.NativeFieldInfoPtr_GeomSegmentsMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "GeomSegmentsMin");
				Consts.Beam.NativeFieldInfoPtr_GeomSegmentsMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "GeomSegmentsMax");
				Consts.Beam.NativeFieldInfoPtr_GeomCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "GeomCap");
				Consts.Beam.NativeFieldInfoPtr_ScalableDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "ScalableDefault");
				Consts.Beam.NativeFieldInfoPtr_AttenuationEquationDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "AttenuationEquationDefault");
				Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "AttenuationCustomBlendingDefault");
				Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "AttenuationCustomBlendingMin");
				Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "AttenuationCustomBlendingMax");
				Consts.Beam.NativeFieldInfoPtr_FallOffStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "FallOffStart");
				Consts.Beam.NativeFieldInfoPtr_FallOffEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "FallOffEnd");
				Consts.Beam.NativeFieldInfoPtr_FallOffDistancesMinThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "FallOffDistancesMinThreshold");
				Consts.Beam.NativeFieldInfoPtr_DepthBlendDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "DepthBlendDistance");
				Consts.Beam.NativeFieldInfoPtr_CameraClippingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "CameraClippingDistance");
				Consts.Beam.NativeFieldInfoPtr_NoiseModeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "NoiseModeDefault");
				Consts.Beam.NativeFieldInfoPtr_NoiseIntensityMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "NoiseIntensityMin");
				Consts.Beam.NativeFieldInfoPtr_NoiseIntensityMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "NoiseIntensityMax");
				Consts.Beam.NativeFieldInfoPtr_NoiseIntensityDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "NoiseIntensityDefault");
				Consts.Beam.NativeFieldInfoPtr_NoiseScaleMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "NoiseScaleMin");
				Consts.Beam.NativeFieldInfoPtr_NoiseScaleMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "NoiseScaleMax");
				Consts.Beam.NativeFieldInfoPtr_NoiseScaleDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "NoiseScaleDefault");
				Consts.Beam.NativeFieldInfoPtr_NoiseVelocityDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "NoiseVelocityDefault");
				Consts.Beam.NativeFieldInfoPtr_BlendingModeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "BlendingModeDefault");
				Consts.Beam.NativeFieldInfoPtr_ShaderAccuracyDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "ShaderAccuracyDefault");
				Consts.Beam.NativeFieldInfoPtr_FadeOutBeginDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "FadeOutBeginDefault");
				Consts.Beam.NativeFieldInfoPtr_FadeOutEndDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "FadeOutEndDefault");
				Consts.Beam.NativeFieldInfoPtr_DimensionsDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "DimensionsDefault");
			}

			// Token: 0x0600BD21 RID: 48417 RVA: 0x0005C936 File Offset: 0x0005AB36
			public Beam(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003AA5 RID: 15013
			// (get) Token: 0x0600BD22 RID: 48418 RVA: 0x002E9764 File Offset: 0x002E7964
			// (set) Token: 0x0600BD23 RID: 48419 RVA: 0x0005C93F File Offset: 0x0005AB3F
			public unsafe static Color FlatColor
			{
				get
				{
					Color result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_FlatColor, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_FlatColor, (void*)(&value));
				}
			}

			// Token: 0x17003AA6 RID: 15014
			// (get) Token: 0x0600BD24 RID: 48420 RVA: 0x002E9780 File Offset: 0x002E7980
			// (set) Token: 0x0600BD25 RID: 48421 RVA: 0x0005C94D File Offset: 0x0005AB4D
			public unsafe static ColorMode ColorModeDefault
			{
				get
				{
					ColorMode result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_ColorModeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_ColorModeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AA7 RID: 15015
			// (get) Token: 0x0600BD26 RID: 48422 RVA: 0x002E979C File Offset: 0x002E799C
			// (set) Token: 0x0600BD27 RID: 48423 RVA: 0x0005C95B File Offset: 0x0005AB5B
			public unsafe static float MultiplierDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_MultiplierDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_MultiplierDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AA8 RID: 15016
			// (get) Token: 0x0600BD28 RID: 48424 RVA: 0x002E97B8 File Offset: 0x002E79B8
			// (set) Token: 0x0600BD29 RID: 48425 RVA: 0x0005C969 File Offset: 0x0005AB69
			public unsafe static float MultiplierMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_MultiplierMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_MultiplierMin, (void*)(&value));
				}
			}

			// Token: 0x17003AA9 RID: 15017
			// (get) Token: 0x0600BD2A RID: 48426 RVA: 0x002E97D4 File Offset: 0x002E79D4
			// (set) Token: 0x0600BD2B RID: 48427 RVA: 0x0005C977 File Offset: 0x0005AB77
			public unsafe static float IntensityDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_IntensityDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_IntensityDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AAA RID: 15018
			// (get) Token: 0x0600BD2C RID: 48428 RVA: 0x002E97F0 File Offset: 0x002E79F0
			// (set) Token: 0x0600BD2D RID: 48429 RVA: 0x0005C985 File Offset: 0x0005AB85
			public unsafe static float IntensityMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_IntensityMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_IntensityMin, (void*)(&value));
				}
			}

			// Token: 0x17003AAB RID: 15019
			// (get) Token: 0x0600BD2E RID: 48430 RVA: 0x002E980C File Offset: 0x002E7A0C
			// (set) Token: 0x0600BD2F RID: 48431 RVA: 0x0005C993 File Offset: 0x0005AB93
			public unsafe static float HDRPExposureWeightDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AAC RID: 15020
			// (get) Token: 0x0600BD30 RID: 48432 RVA: 0x002E9828 File Offset: 0x002E7A28
			// (set) Token: 0x0600BD31 RID: 48433 RVA: 0x0005C9A1 File Offset: 0x0005ABA1
			public unsafe static float HDRPExposureWeightMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightMin, (void*)(&value));
				}
			}

			// Token: 0x17003AAD RID: 15021
			// (get) Token: 0x0600BD32 RID: 48434 RVA: 0x002E9844 File Offset: 0x002E7A44
			// (set) Token: 0x0600BD33 RID: 48435 RVA: 0x0005C9AF File Offset: 0x0005ABAF
			public unsafe static float HDRPExposureWeightMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightMax, (void*)(&value));
				}
			}

			// Token: 0x17003AAE RID: 15022
			// (get) Token: 0x0600BD34 RID: 48436 RVA: 0x002E9860 File Offset: 0x002E7A60
			// (set) Token: 0x0600BD35 RID: 48437 RVA: 0x0005C9BD File Offset: 0x0005ABBD
			public unsafe static float SpotAngleDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_SpotAngleDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_SpotAngleDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AAF RID: 15023
			// (get) Token: 0x0600BD36 RID: 48438 RVA: 0x002E987C File Offset: 0x002E7A7C
			// (set) Token: 0x0600BD37 RID: 48439 RVA: 0x0005C9CB File Offset: 0x0005ABCB
			public unsafe static float SpotAngleMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_SpotAngleMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_SpotAngleMin, (void*)(&value));
				}
			}

			// Token: 0x17003AB0 RID: 15024
			// (get) Token: 0x0600BD38 RID: 48440 RVA: 0x002E9898 File Offset: 0x002E7A98
			// (set) Token: 0x0600BD39 RID: 48441 RVA: 0x0005C9D9 File Offset: 0x0005ABD9
			public unsafe static float SpotAngleMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_SpotAngleMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_SpotAngleMax, (void*)(&value));
				}
			}

			// Token: 0x17003AB1 RID: 15025
			// (get) Token: 0x0600BD3A RID: 48442 RVA: 0x002E98B4 File Offset: 0x002E7AB4
			// (set) Token: 0x0600BD3B RID: 48443 RVA: 0x0005C9E7 File Offset: 0x0005ABE7
			public unsafe static float ConeRadiusStart
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_ConeRadiusStart, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_ConeRadiusStart, (void*)(&value));
				}
			}

			// Token: 0x17003AB2 RID: 15026
			// (get) Token: 0x0600BD3C RID: 48444 RVA: 0x002E98D0 File Offset: 0x002E7AD0
			// (set) Token: 0x0600BD3D RID: 48445 RVA: 0x0005C9F5 File Offset: 0x0005ABF5
			public unsafe static MeshType GeomMeshType
			{
				get
				{
					MeshType result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_GeomMeshType, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_GeomMeshType, (void*)(&value));
				}
			}

			// Token: 0x17003AB3 RID: 15027
			// (get) Token: 0x0600BD3E RID: 48446 RVA: 0x002E98EC File Offset: 0x002E7AEC
			// (set) Token: 0x0600BD3F RID: 48447 RVA: 0x0005CA03 File Offset: 0x0005AC03
			public unsafe static int GeomSidesDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_GeomSidesDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_GeomSidesDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AB4 RID: 15028
			// (get) Token: 0x0600BD40 RID: 48448 RVA: 0x002E9908 File Offset: 0x002E7B08
			// (set) Token: 0x0600BD41 RID: 48449 RVA: 0x0005CA11 File Offset: 0x0005AC11
			public unsafe static int GeomSidesMin
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_GeomSidesMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_GeomSidesMin, (void*)(&value));
				}
			}

			// Token: 0x17003AB5 RID: 15029
			// (get) Token: 0x0600BD42 RID: 48450 RVA: 0x002E9924 File Offset: 0x002E7B24
			// (set) Token: 0x0600BD43 RID: 48451 RVA: 0x0005CA1F File Offset: 0x0005AC1F
			public unsafe static int GeomSidesMax
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_GeomSidesMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_GeomSidesMax, (void*)(&value));
				}
			}

			// Token: 0x17003AB6 RID: 15030
			// (get) Token: 0x0600BD44 RID: 48452 RVA: 0x002E9940 File Offset: 0x002E7B40
			// (set) Token: 0x0600BD45 RID: 48453 RVA: 0x0005CA2D File Offset: 0x0005AC2D
			public unsafe static int GeomSegmentsDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_GeomSegmentsDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_GeomSegmentsDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AB7 RID: 15031
			// (get) Token: 0x0600BD46 RID: 48454 RVA: 0x002E995C File Offset: 0x002E7B5C
			// (set) Token: 0x0600BD47 RID: 48455 RVA: 0x0005CA3B File Offset: 0x0005AC3B
			public unsafe static int GeomSegmentsMin
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_GeomSegmentsMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_GeomSegmentsMin, (void*)(&value));
				}
			}

			// Token: 0x17003AB8 RID: 15032
			// (get) Token: 0x0600BD48 RID: 48456 RVA: 0x002E9978 File Offset: 0x002E7B78
			// (set) Token: 0x0600BD49 RID: 48457 RVA: 0x0005CA49 File Offset: 0x0005AC49
			public unsafe static int GeomSegmentsMax
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_GeomSegmentsMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_GeomSegmentsMax, (void*)(&value));
				}
			}

			// Token: 0x17003AB9 RID: 15033
			// (get) Token: 0x0600BD4A RID: 48458 RVA: 0x002E9994 File Offset: 0x002E7B94
			// (set) Token: 0x0600BD4B RID: 48459 RVA: 0x0005CA57 File Offset: 0x0005AC57
			public unsafe static bool GeomCap
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_GeomCap, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_GeomCap, (void*)(&value));
				}
			}

			// Token: 0x17003ABA RID: 15034
			// (get) Token: 0x0600BD4C RID: 48460 RVA: 0x002E99B0 File Offset: 0x002E7BB0
			// (set) Token: 0x0600BD4D RID: 48461 RVA: 0x0005CA65 File Offset: 0x0005AC65
			public unsafe static bool ScalableDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_ScalableDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_ScalableDefault, (void*)(&value));
				}
			}

			// Token: 0x17003ABB RID: 15035
			// (get) Token: 0x0600BD4E RID: 48462 RVA: 0x002E99CC File Offset: 0x002E7BCC
			// (set) Token: 0x0600BD4F RID: 48463 RVA: 0x0005CA73 File Offset: 0x0005AC73
			public unsafe static AttenuationEquation AttenuationEquationDefault
			{
				get
				{
					AttenuationEquation result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_AttenuationEquationDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_AttenuationEquationDefault, (void*)(&value));
				}
			}

			// Token: 0x17003ABC RID: 15036
			// (get) Token: 0x0600BD50 RID: 48464 RVA: 0x002E99E8 File Offset: 0x002E7BE8
			// (set) Token: 0x0600BD51 RID: 48465 RVA: 0x0005CA81 File Offset: 0x0005AC81
			public unsafe static float AttenuationCustomBlendingDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingDefault, (void*)(&value));
				}
			}

			// Token: 0x17003ABD RID: 15037
			// (get) Token: 0x0600BD52 RID: 48466 RVA: 0x002E9A04 File Offset: 0x002E7C04
			// (set) Token: 0x0600BD53 RID: 48467 RVA: 0x0005CA8F File Offset: 0x0005AC8F
			public unsafe static float AttenuationCustomBlendingMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingMin, (void*)(&value));
				}
			}

			// Token: 0x17003ABE RID: 15038
			// (get) Token: 0x0600BD54 RID: 48468 RVA: 0x002E9A20 File Offset: 0x002E7C20
			// (set) Token: 0x0600BD55 RID: 48469 RVA: 0x0005CA9D File Offset: 0x0005AC9D
			public unsafe static float AttenuationCustomBlendingMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingMax, (void*)(&value));
				}
			}

			// Token: 0x17003ABF RID: 15039
			// (get) Token: 0x0600BD56 RID: 48470 RVA: 0x002E9A3C File Offset: 0x002E7C3C
			// (set) Token: 0x0600BD57 RID: 48471 RVA: 0x0005CAAB File Offset: 0x0005ACAB
			public unsafe static float FallOffStart
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_FallOffStart, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_FallOffStart, (void*)(&value));
				}
			}

			// Token: 0x17003AC0 RID: 15040
			// (get) Token: 0x0600BD58 RID: 48472 RVA: 0x002E9A58 File Offset: 0x002E7C58
			// (set) Token: 0x0600BD59 RID: 48473 RVA: 0x0005CAB9 File Offset: 0x0005ACB9
			public unsafe static float FallOffEnd
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_FallOffEnd, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_FallOffEnd, (void*)(&value));
				}
			}

			// Token: 0x17003AC1 RID: 15041
			// (get) Token: 0x0600BD5A RID: 48474 RVA: 0x002E9A74 File Offset: 0x002E7C74
			// (set) Token: 0x0600BD5B RID: 48475 RVA: 0x0005CAC7 File Offset: 0x0005ACC7
			public unsafe static float FallOffDistancesMinThreshold
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_FallOffDistancesMinThreshold, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_FallOffDistancesMinThreshold, (void*)(&value));
				}
			}

			// Token: 0x17003AC2 RID: 15042
			// (get) Token: 0x0600BD5C RID: 48476 RVA: 0x002E9A90 File Offset: 0x002E7C90
			// (set) Token: 0x0600BD5D RID: 48477 RVA: 0x0005CAD5 File Offset: 0x0005ACD5
			public unsafe static float DepthBlendDistance
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_DepthBlendDistance, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_DepthBlendDistance, (void*)(&value));
				}
			}

			// Token: 0x17003AC3 RID: 15043
			// (get) Token: 0x0600BD5E RID: 48478 RVA: 0x002E9AAC File Offset: 0x002E7CAC
			// (set) Token: 0x0600BD5F RID: 48479 RVA: 0x0005CAE3 File Offset: 0x0005ACE3
			public unsafe static float CameraClippingDistance
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_CameraClippingDistance, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_CameraClippingDistance, (void*)(&value));
				}
			}

			// Token: 0x17003AC4 RID: 15044
			// (get) Token: 0x0600BD60 RID: 48480 RVA: 0x002E9AC8 File Offset: 0x002E7CC8
			// (set) Token: 0x0600BD61 RID: 48481 RVA: 0x0005CAF1 File Offset: 0x0005ACF1
			public unsafe static NoiseMode NoiseModeDefault
			{
				get
				{
					NoiseMode result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_NoiseModeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_NoiseModeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AC5 RID: 15045
			// (get) Token: 0x0600BD62 RID: 48482 RVA: 0x002E9AE4 File Offset: 0x002E7CE4
			// (set) Token: 0x0600BD63 RID: 48483 RVA: 0x0005CAFF File Offset: 0x0005ACFF
			public unsafe static float NoiseIntensityMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_NoiseIntensityMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_NoiseIntensityMin, (void*)(&value));
				}
			}

			// Token: 0x17003AC6 RID: 15046
			// (get) Token: 0x0600BD64 RID: 48484 RVA: 0x002E9B00 File Offset: 0x002E7D00
			// (set) Token: 0x0600BD65 RID: 48485 RVA: 0x0005CB0D File Offset: 0x0005AD0D
			public unsafe static float NoiseIntensityMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_NoiseIntensityMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_NoiseIntensityMax, (void*)(&value));
				}
			}

			// Token: 0x17003AC7 RID: 15047
			// (get) Token: 0x0600BD66 RID: 48486 RVA: 0x002E9B1C File Offset: 0x002E7D1C
			// (set) Token: 0x0600BD67 RID: 48487 RVA: 0x0005CB1B File Offset: 0x0005AD1B
			public unsafe static float NoiseIntensityDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_NoiseIntensityDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_NoiseIntensityDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AC8 RID: 15048
			// (get) Token: 0x0600BD68 RID: 48488 RVA: 0x002E9B38 File Offset: 0x002E7D38
			// (set) Token: 0x0600BD69 RID: 48489 RVA: 0x0005CB29 File Offset: 0x0005AD29
			public unsafe static float NoiseScaleMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_NoiseScaleMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_NoiseScaleMin, (void*)(&value));
				}
			}

			// Token: 0x17003AC9 RID: 15049
			// (get) Token: 0x0600BD6A RID: 48490 RVA: 0x002E9B54 File Offset: 0x002E7D54
			// (set) Token: 0x0600BD6B RID: 48491 RVA: 0x0005CB37 File Offset: 0x0005AD37
			public unsafe static float NoiseScaleMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_NoiseScaleMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_NoiseScaleMax, (void*)(&value));
				}
			}

			// Token: 0x17003ACA RID: 15050
			// (get) Token: 0x0600BD6C RID: 48492 RVA: 0x002E9B70 File Offset: 0x002E7D70
			// (set) Token: 0x0600BD6D RID: 48493 RVA: 0x0005CB45 File Offset: 0x0005AD45
			public unsafe static float NoiseScaleDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_NoiseScaleDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_NoiseScaleDefault, (void*)(&value));
				}
			}

			// Token: 0x17003ACB RID: 15051
			// (get) Token: 0x0600BD6E RID: 48494 RVA: 0x002E9B8C File Offset: 0x002E7D8C
			// (set) Token: 0x0600BD6F RID: 48495 RVA: 0x0005CB53 File Offset: 0x0005AD53
			public unsafe static Vector3 NoiseVelocityDefault
			{
				get
				{
					Vector3 result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_NoiseVelocityDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_NoiseVelocityDefault, (void*)(&value));
				}
			}

			// Token: 0x17003ACC RID: 15052
			// (get) Token: 0x0600BD70 RID: 48496 RVA: 0x002E9BA8 File Offset: 0x002E7DA8
			// (set) Token: 0x0600BD71 RID: 48497 RVA: 0x0005CB61 File Offset: 0x0005AD61
			public unsafe static BlendingMode BlendingModeDefault
			{
				get
				{
					BlendingMode result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_BlendingModeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_BlendingModeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003ACD RID: 15053
			// (get) Token: 0x0600BD72 RID: 48498 RVA: 0x002E9BC4 File Offset: 0x002E7DC4
			// (set) Token: 0x0600BD73 RID: 48499 RVA: 0x0005CB6F File Offset: 0x0005AD6F
			public unsafe static ShaderAccuracy ShaderAccuracyDefault
			{
				get
				{
					ShaderAccuracy result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_ShaderAccuracyDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_ShaderAccuracyDefault, (void*)(&value));
				}
			}

			// Token: 0x17003ACE RID: 15054
			// (get) Token: 0x0600BD74 RID: 48500 RVA: 0x002E9BE0 File Offset: 0x002E7DE0
			// (set) Token: 0x0600BD75 RID: 48501 RVA: 0x0005CB7D File Offset: 0x0005AD7D
			public unsafe static float FadeOutBeginDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_FadeOutBeginDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_FadeOutBeginDefault, (void*)(&value));
				}
			}

			// Token: 0x17003ACF RID: 15055
			// (get) Token: 0x0600BD76 RID: 48502 RVA: 0x002E9BFC File Offset: 0x002E7DFC
			// (set) Token: 0x0600BD77 RID: 48503 RVA: 0x0005CB8B File Offset: 0x0005AD8B
			public unsafe static float FadeOutEndDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_FadeOutEndDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_FadeOutEndDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AD0 RID: 15056
			// (get) Token: 0x0600BD78 RID: 48504 RVA: 0x002E9C18 File Offset: 0x002E7E18
			// (set) Token: 0x0600BD79 RID: 48505 RVA: 0x0005CB99 File Offset: 0x0005AD99
			public unsafe static Dimensions DimensionsDefault
			{
				get
				{
					Dimensions result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_DimensionsDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_DimensionsDefault, (void*)(&value));
				}
			}

			// Token: 0x04008023 RID: 32803
			private static readonly IntPtr NativeFieldInfoPtr_FlatColor;

			// Token: 0x04008024 RID: 32804
			private static readonly IntPtr NativeFieldInfoPtr_ColorModeDefault;

			// Token: 0x04008025 RID: 32805
			private static readonly IntPtr NativeFieldInfoPtr_MultiplierDefault;

			// Token: 0x04008026 RID: 32806
			private static readonly IntPtr NativeFieldInfoPtr_MultiplierMin;

			// Token: 0x04008027 RID: 32807
			private static readonly IntPtr NativeFieldInfoPtr_IntensityDefault;

			// Token: 0x04008028 RID: 32808
			private static readonly IntPtr NativeFieldInfoPtr_IntensityMin;

			// Token: 0x04008029 RID: 32809
			private static readonly IntPtr NativeFieldInfoPtr_HDRPExposureWeightDefault;

			// Token: 0x0400802A RID: 32810
			private static readonly IntPtr NativeFieldInfoPtr_HDRPExposureWeightMin;

			// Token: 0x0400802B RID: 32811
			private static readonly IntPtr NativeFieldInfoPtr_HDRPExposureWeightMax;

			// Token: 0x0400802C RID: 32812
			private static readonly IntPtr NativeFieldInfoPtr_SpotAngleDefault;

			// Token: 0x0400802D RID: 32813
			private static readonly IntPtr NativeFieldInfoPtr_SpotAngleMin;

			// Token: 0x0400802E RID: 32814
			private static readonly IntPtr NativeFieldInfoPtr_SpotAngleMax;

			// Token: 0x0400802F RID: 32815
			private static readonly IntPtr NativeFieldInfoPtr_ConeRadiusStart;

			// Token: 0x04008030 RID: 32816
			private static readonly IntPtr NativeFieldInfoPtr_GeomMeshType;

			// Token: 0x04008031 RID: 32817
			private static readonly IntPtr NativeFieldInfoPtr_GeomSidesDefault;

			// Token: 0x04008032 RID: 32818
			private static readonly IntPtr NativeFieldInfoPtr_GeomSidesMin;

			// Token: 0x04008033 RID: 32819
			private static readonly IntPtr NativeFieldInfoPtr_GeomSidesMax;

			// Token: 0x04008034 RID: 32820
			private static readonly IntPtr NativeFieldInfoPtr_GeomSegmentsDefault;

			// Token: 0x04008035 RID: 32821
			private static readonly IntPtr NativeFieldInfoPtr_GeomSegmentsMin;

			// Token: 0x04008036 RID: 32822
			private static readonly IntPtr NativeFieldInfoPtr_GeomSegmentsMax;

			// Token: 0x04008037 RID: 32823
			private static readonly IntPtr NativeFieldInfoPtr_GeomCap;

			// Token: 0x04008038 RID: 32824
			private static readonly IntPtr NativeFieldInfoPtr_ScalableDefault;

			// Token: 0x04008039 RID: 32825
			private static readonly IntPtr NativeFieldInfoPtr_AttenuationEquationDefault;

			// Token: 0x0400803A RID: 32826
			private static readonly IntPtr NativeFieldInfoPtr_AttenuationCustomBlendingDefault;

			// Token: 0x0400803B RID: 32827
			private static readonly IntPtr NativeFieldInfoPtr_AttenuationCustomBlendingMin;

			// Token: 0x0400803C RID: 32828
			private static readonly IntPtr NativeFieldInfoPtr_AttenuationCustomBlendingMax;

			// Token: 0x0400803D RID: 32829
			private static readonly IntPtr NativeFieldInfoPtr_FallOffStart;

			// Token: 0x0400803E RID: 32830
			private static readonly IntPtr NativeFieldInfoPtr_FallOffEnd;

			// Token: 0x0400803F RID: 32831
			private static readonly IntPtr NativeFieldInfoPtr_FallOffDistancesMinThreshold;

			// Token: 0x04008040 RID: 32832
			private static readonly IntPtr NativeFieldInfoPtr_DepthBlendDistance;

			// Token: 0x04008041 RID: 32833
			private static readonly IntPtr NativeFieldInfoPtr_CameraClippingDistance;

			// Token: 0x04008042 RID: 32834
			private static readonly IntPtr NativeFieldInfoPtr_NoiseModeDefault;

			// Token: 0x04008043 RID: 32835
			private static readonly IntPtr NativeFieldInfoPtr_NoiseIntensityMin;

			// Token: 0x04008044 RID: 32836
			private static readonly IntPtr NativeFieldInfoPtr_NoiseIntensityMax;

			// Token: 0x04008045 RID: 32837
			private static readonly IntPtr NativeFieldInfoPtr_NoiseIntensityDefault;

			// Token: 0x04008046 RID: 32838
			private static readonly IntPtr NativeFieldInfoPtr_NoiseScaleMin;

			// Token: 0x04008047 RID: 32839
			private static readonly IntPtr NativeFieldInfoPtr_NoiseScaleMax;

			// Token: 0x04008048 RID: 32840
			private static readonly IntPtr NativeFieldInfoPtr_NoiseScaleDefault;

			// Token: 0x04008049 RID: 32841
			private static readonly IntPtr NativeFieldInfoPtr_NoiseVelocityDefault;

			// Token: 0x0400804A RID: 32842
			private static readonly IntPtr NativeFieldInfoPtr_BlendingModeDefault;

			// Token: 0x0400804B RID: 32843
			private static readonly IntPtr NativeFieldInfoPtr_ShaderAccuracyDefault;

			// Token: 0x0400804C RID: 32844
			private static readonly IntPtr NativeFieldInfoPtr_FadeOutBeginDefault;

			// Token: 0x0400804D RID: 32845
			private static readonly IntPtr NativeFieldInfoPtr_FadeOutEndDefault;

			// Token: 0x0400804E RID: 32846
			private static readonly IntPtr NativeFieldInfoPtr_DimensionsDefault;

			// Token: 0x02000C20 RID: 3104
			public static class SD : Il2CppSystem.Object
			{
				// Token: 0x0600E0C3 RID: 57539 RVA: 0x0034E060 File Offset: 0x0034C260
				// Note: this type is marked as 'beforefieldinit'.
				static SD()
				{
					Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "SD");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr);
					Consts.Beam.SD.NativeFieldInfoPtr_FresnelPowMaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "FresnelPowMaxValue");
					Consts.Beam.SD.NativeFieldInfoPtr_FresnelPow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "FresnelPow");
					Consts.Beam.SD.NativeFieldInfoPtr_GlareFrontalDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "GlareFrontalDefault");
					Consts.Beam.SD.NativeFieldInfoPtr_GlareBehindDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "GlareBehindDefault");
					Consts.Beam.SD.NativeFieldInfoPtr_GlareMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "GlareMin");
					Consts.Beam.SD.NativeFieldInfoPtr_GlareMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "GlareMax");
					Consts.Beam.SD.NativeFieldInfoPtr_TiltDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "TiltDefault");
					Consts.Beam.SD.NativeFieldInfoPtr_SkewingLocalForwardDirectionDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "SkewingLocalForwardDirectionDefault");
					Consts.Beam.SD.NativeFieldInfoPtr_ClippingPlaneTransformDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "ClippingPlaneTransformDefault");
				}

				// Token: 0x0600E0C4 RID: 57540 RVA: 0x0006D96A File Offset: 0x0006BB6A
				public SD(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700459B RID: 17819
				// (get) Token: 0x0600E0C5 RID: 57541 RVA: 0x0034E140 File Offset: 0x0034C340
				// (set) Token: 0x0600E0C6 RID: 57542 RVA: 0x0006D973 File Offset: 0x0006BB73
				public unsafe static float FresnelPowMaxValue
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_FresnelPowMaxValue, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_FresnelPowMaxValue, (void*)(&value));
					}
				}

				// Token: 0x1700459C RID: 17820
				// (get) Token: 0x0600E0C7 RID: 57543 RVA: 0x0034E15C File Offset: 0x0034C35C
				// (set) Token: 0x0600E0C8 RID: 57544 RVA: 0x0006D981 File Offset: 0x0006BB81
				public unsafe static float FresnelPow
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_FresnelPow, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_FresnelPow, (void*)(&value));
					}
				}

				// Token: 0x1700459D RID: 17821
				// (get) Token: 0x0600E0C9 RID: 57545 RVA: 0x0034E178 File Offset: 0x0034C378
				// (set) Token: 0x0600E0CA RID: 57546 RVA: 0x0006D98F File Offset: 0x0006BB8F
				public unsafe static float GlareFrontalDefault
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_GlareFrontalDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_GlareFrontalDefault, (void*)(&value));
					}
				}

				// Token: 0x1700459E RID: 17822
				// (get) Token: 0x0600E0CB RID: 57547 RVA: 0x0034E194 File Offset: 0x0034C394
				// (set) Token: 0x0600E0CC RID: 57548 RVA: 0x0006D99D File Offset: 0x0006BB9D
				public unsafe static float GlareBehindDefault
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_GlareBehindDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_GlareBehindDefault, (void*)(&value));
					}
				}

				// Token: 0x1700459F RID: 17823
				// (get) Token: 0x0600E0CD RID: 57549 RVA: 0x0034E1B0 File Offset: 0x0034C3B0
				// (set) Token: 0x0600E0CE RID: 57550 RVA: 0x0006D9AB File Offset: 0x0006BBAB
				public unsafe static float GlareMin
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_GlareMin, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_GlareMin, (void*)(&value));
					}
				}

				// Token: 0x170045A0 RID: 17824
				// (get) Token: 0x0600E0CF RID: 57551 RVA: 0x0034E1CC File Offset: 0x0034C3CC
				// (set) Token: 0x0600E0D0 RID: 57552 RVA: 0x0006D9B9 File Offset: 0x0006BBB9
				public unsafe static float GlareMax
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_GlareMax, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_GlareMax, (void*)(&value));
					}
				}

				// Token: 0x170045A1 RID: 17825
				// (get) Token: 0x0600E0D1 RID: 57553 RVA: 0x0034E1E8 File Offset: 0x0034C3E8
				// (set) Token: 0x0600E0D2 RID: 57554 RVA: 0x0006D9C7 File Offset: 0x0006BBC7
				public unsafe static Vector2 TiltDefault
				{
					get
					{
						Vector2 result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_TiltDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_TiltDefault, (void*)(&value));
					}
				}

				// Token: 0x170045A2 RID: 17826
				// (get) Token: 0x0600E0D3 RID: 57555 RVA: 0x0034E204 File Offset: 0x0034C404
				// (set) Token: 0x0600E0D4 RID: 57556 RVA: 0x0006D9D5 File Offset: 0x0006BBD5
				public unsafe static Vector3 SkewingLocalForwardDirectionDefault
				{
					get
					{
						Vector3 result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_SkewingLocalForwardDirectionDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_SkewingLocalForwardDirectionDefault, (void*)(&value));
					}
				}

				// Token: 0x170045A3 RID: 17827
				// (get) Token: 0x0600E0D5 RID: 57557 RVA: 0x0034E220 File Offset: 0x0034C420
				// (set) Token: 0x0600E0D6 RID: 57558 RVA: 0x0006D9E3 File Offset: 0x0006BBE3
				public unsafe static Transform ClippingPlaneTransformDefault
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_ClippingPlaneTransformDefault, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_ClippingPlaneTransformDefault, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009674 RID: 38516
				private static readonly IntPtr NativeFieldInfoPtr_FresnelPowMaxValue;

				// Token: 0x04009675 RID: 38517
				private static readonly IntPtr NativeFieldInfoPtr_FresnelPow;

				// Token: 0x04009676 RID: 38518
				private static readonly IntPtr NativeFieldInfoPtr_GlareFrontalDefault;

				// Token: 0x04009677 RID: 38519
				private static readonly IntPtr NativeFieldInfoPtr_GlareBehindDefault;

				// Token: 0x04009678 RID: 38520
				private static readonly IntPtr NativeFieldInfoPtr_GlareMin;

				// Token: 0x04009679 RID: 38521
				private static readonly IntPtr NativeFieldInfoPtr_GlareMax;

				// Token: 0x0400967A RID: 38522
				private static readonly IntPtr NativeFieldInfoPtr_TiltDefault;

				// Token: 0x0400967B RID: 38523
				private static readonly IntPtr NativeFieldInfoPtr_SkewingLocalForwardDirectionDefault;

				// Token: 0x0400967C RID: 38524
				private static readonly IntPtr NativeFieldInfoPtr_ClippingPlaneTransformDefault;
			}

			// Token: 0x02000C21 RID: 3105
			public static class HD : Il2CppSystem.Object
			{
				// Token: 0x0600E0D7 RID: 57559 RVA: 0x0034E248 File Offset: 0x0034C448
				// Note: this type is marked as 'beforefieldinit'.
				static HD()
				{
					Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "HD");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr);
					Consts.Beam.HD.NativeFieldInfoPtr_AttenuationEquationDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "AttenuationEquationDefault");
					Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "SideSoftnessDefault");
					Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "SideSoftnessMin");
					Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "SideSoftnessMax");
					Consts.Beam.HD.NativeFieldInfoPtr_JitteringFactorDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "JitteringFactorDefault");
					Consts.Beam.HD.NativeFieldInfoPtr_JitteringFactorMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "JitteringFactorMin");
					Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "JitteringFrameRateDefault");
					Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "JitteringFrameRateMin");
					Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "JitteringFrameRateMax");
					Consts.Beam.HD.NativeFieldInfoPtr_JitteringLerpRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "JitteringLerpRange");
				}

				// Token: 0x0600E0D8 RID: 57560 RVA: 0x0006D9F5 File Offset: 0x0006BBF5
				public HD(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045A4 RID: 17828
				// (get) Token: 0x0600E0D9 RID: 57561 RVA: 0x0034E33C File Offset: 0x0034C53C
				// (set) Token: 0x0600E0DA RID: 57562 RVA: 0x0006D9FE File Offset: 0x0006BBFE
				public unsafe static AttenuationEquationHD AttenuationEquationDefault
				{
					get
					{
						AttenuationEquationHD result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_AttenuationEquationDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_AttenuationEquationDefault, (void*)(&value));
					}
				}

				// Token: 0x170045A5 RID: 17829
				// (get) Token: 0x0600E0DB RID: 57563 RVA: 0x0034E358 File Offset: 0x0034C558
				// (set) Token: 0x0600E0DC RID: 57564 RVA: 0x0006DA0C File Offset: 0x0006BC0C
				public unsafe static float SideSoftnessDefault
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessDefault, (void*)(&value));
					}
				}

				// Token: 0x170045A6 RID: 17830
				// (get) Token: 0x0600E0DD RID: 57565 RVA: 0x0034E374 File Offset: 0x0034C574
				// (set) Token: 0x0600E0DE RID: 57566 RVA: 0x0006DA1A File Offset: 0x0006BC1A
				public unsafe static float SideSoftnessMin
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessMin, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessMin, (void*)(&value));
					}
				}

				// Token: 0x170045A7 RID: 17831
				// (get) Token: 0x0600E0DF RID: 57567 RVA: 0x0034E390 File Offset: 0x0034C590
				// (set) Token: 0x0600E0E0 RID: 57568 RVA: 0x0006DA28 File Offset: 0x0006BC28
				public unsafe static float SideSoftnessMax
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessMax, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessMax, (void*)(&value));
					}
				}

				// Token: 0x170045A8 RID: 17832
				// (get) Token: 0x0600E0E1 RID: 57569 RVA: 0x0034E3AC File Offset: 0x0034C5AC
				// (set) Token: 0x0600E0E2 RID: 57570 RVA: 0x0006DA36 File Offset: 0x0006BC36
				public unsafe static float JitteringFactorDefault
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFactorDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFactorDefault, (void*)(&value));
					}
				}

				// Token: 0x170045A9 RID: 17833
				// (get) Token: 0x0600E0E3 RID: 57571 RVA: 0x0034E3C8 File Offset: 0x0034C5C8
				// (set) Token: 0x0600E0E4 RID: 57572 RVA: 0x0006DA44 File Offset: 0x0006BC44
				public unsafe static float JitteringFactorMin
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFactorMin, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFactorMin, (void*)(&value));
					}
				}

				// Token: 0x170045AA RID: 17834
				// (get) Token: 0x0600E0E5 RID: 57573 RVA: 0x0034E3E4 File Offset: 0x0034C5E4
				// (set) Token: 0x0600E0E6 RID: 57574 RVA: 0x0006DA52 File Offset: 0x0006BC52
				public unsafe static int JitteringFrameRateDefault
				{
					get
					{
						int result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateDefault, (void*)(&value));
					}
				}

				// Token: 0x170045AB RID: 17835
				// (get) Token: 0x0600E0E7 RID: 57575 RVA: 0x0034E400 File Offset: 0x0034C600
				// (set) Token: 0x0600E0E8 RID: 57576 RVA: 0x0006DA60 File Offset: 0x0006BC60
				public unsafe static int JitteringFrameRateMin
				{
					get
					{
						int result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateMin, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateMin, (void*)(&value));
					}
				}

				// Token: 0x170045AC RID: 17836
				// (get) Token: 0x0600E0E9 RID: 57577 RVA: 0x0034E41C File Offset: 0x0034C61C
				// (set) Token: 0x0600E0EA RID: 57578 RVA: 0x0006DA6E File Offset: 0x0006BC6E
				public unsafe static int JitteringFrameRateMax
				{
					get
					{
						int result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateMax, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateMax, (void*)(&value));
					}
				}

				// Token: 0x170045AD RID: 17837
				// (get) Token: 0x0600E0EB RID: 57579 RVA: 0x0034E438 File Offset: 0x0034C638
				// (set) Token: 0x0600E0EC RID: 57580 RVA: 0x0006DA7C File Offset: 0x0006BC7C
				public unsafe static MinMaxRangeFloat JitteringLerpRange
				{
					get
					{
						MinMaxRangeFloat result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringLerpRange, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringLerpRange, (void*)(&value));
					}
				}

				// Token: 0x0400967D RID: 38525
				private static readonly IntPtr NativeFieldInfoPtr_AttenuationEquationDefault;

				// Token: 0x0400967E RID: 38526
				private static readonly IntPtr NativeFieldInfoPtr_SideSoftnessDefault;

				// Token: 0x0400967F RID: 38527
				private static readonly IntPtr NativeFieldInfoPtr_SideSoftnessMin;

				// Token: 0x04009680 RID: 38528
				private static readonly IntPtr NativeFieldInfoPtr_SideSoftnessMax;

				// Token: 0x04009681 RID: 38529
				private static readonly IntPtr NativeFieldInfoPtr_JitteringFactorDefault;

				// Token: 0x04009682 RID: 38530
				private static readonly IntPtr NativeFieldInfoPtr_JitteringFactorMin;

				// Token: 0x04009683 RID: 38531
				private static readonly IntPtr NativeFieldInfoPtr_JitteringFrameRateDefault;

				// Token: 0x04009684 RID: 38532
				private static readonly IntPtr NativeFieldInfoPtr_JitteringFrameRateMin;

				// Token: 0x04009685 RID: 38533
				private static readonly IntPtr NativeFieldInfoPtr_JitteringFrameRateMax;

				// Token: 0x04009686 RID: 38534
				private static readonly IntPtr NativeFieldInfoPtr_JitteringLerpRange;
			}
		}

		// Token: 0x02000810 RID: 2064
		public static class DustParticles : Il2CppSystem.Object
		{
			// Token: 0x0600BD7A RID: 48506 RVA: 0x002E9C34 File Offset: 0x002E7E34
			// Note: this type is marked as 'beforefieldinit'.
			static DustParticles()
			{
				Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "DustParticles");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr);
				Consts.DustParticles.NativeFieldInfoPtr_AlphaDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "AlphaDefault");
				Consts.DustParticles.NativeFieldInfoPtr_SizeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "SizeDefault");
				Consts.DustParticles.NativeFieldInfoPtr_DirectionDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "DirectionDefault");
				Consts.DustParticles.NativeFieldInfoPtr_VelocityDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "VelocityDefault");
				Consts.DustParticles.NativeFieldInfoPtr_DensityDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "DensityDefault");
				Consts.DustParticles.NativeFieldInfoPtr_DensityMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "DensityMin");
				Consts.DustParticles.NativeFieldInfoPtr_DensityMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "DensityMax");
				Consts.DustParticles.NativeFieldInfoPtr_SpawnDistanceRangeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "SpawnDistanceRangeDefault");
				Consts.DustParticles.NativeFieldInfoPtr_CullingEnabledDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "CullingEnabledDefault");
				Consts.DustParticles.NativeFieldInfoPtr_CullingMaxDistanceDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "CullingMaxDistanceDefault");
				Consts.DustParticles.NativeFieldInfoPtr_CullingMaxDistanceMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "CullingMaxDistanceMin");
			}

			// Token: 0x0600BD7B RID: 48507 RVA: 0x0005CBA7 File Offset: 0x0005ADA7
			public DustParticles(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003AD1 RID: 15057
			// (get) Token: 0x0600BD7C RID: 48508 RVA: 0x002E9D3C File Offset: 0x002E7F3C
			// (set) Token: 0x0600BD7D RID: 48509 RVA: 0x0005CBB0 File Offset: 0x0005ADB0
			public unsafe static float AlphaDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_AlphaDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_AlphaDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AD2 RID: 15058
			// (get) Token: 0x0600BD7E RID: 48510 RVA: 0x002E9D58 File Offset: 0x002E7F58
			// (set) Token: 0x0600BD7F RID: 48511 RVA: 0x0005CBBE File Offset: 0x0005ADBE
			public unsafe static float SizeDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_SizeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_SizeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AD3 RID: 15059
			// (get) Token: 0x0600BD80 RID: 48512 RVA: 0x002E9D74 File Offset: 0x002E7F74
			// (set) Token: 0x0600BD81 RID: 48513 RVA: 0x0005CBCC File Offset: 0x0005ADCC
			public unsafe static ParticlesDirection DirectionDefault
			{
				get
				{
					ParticlesDirection result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_DirectionDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_DirectionDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AD4 RID: 15060
			// (get) Token: 0x0600BD82 RID: 48514 RVA: 0x002E9D90 File Offset: 0x002E7F90
			// (set) Token: 0x0600BD83 RID: 48515 RVA: 0x0005CBDA File Offset: 0x0005ADDA
			public unsafe static Vector3 VelocityDefault
			{
				get
				{
					Vector3 result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_VelocityDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_VelocityDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AD5 RID: 15061
			// (get) Token: 0x0600BD84 RID: 48516 RVA: 0x002E9DAC File Offset: 0x002E7FAC
			// (set) Token: 0x0600BD85 RID: 48517 RVA: 0x0005CBE8 File Offset: 0x0005ADE8
			public unsafe static float DensityDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_DensityDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_DensityDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AD6 RID: 15062
			// (get) Token: 0x0600BD86 RID: 48518 RVA: 0x002E9DC8 File Offset: 0x002E7FC8
			// (set) Token: 0x0600BD87 RID: 48519 RVA: 0x0005CBF6 File Offset: 0x0005ADF6
			public unsafe static float DensityMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_DensityMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_DensityMin, (void*)(&value));
				}
			}

			// Token: 0x17003AD7 RID: 15063
			// (get) Token: 0x0600BD88 RID: 48520 RVA: 0x002E9DE4 File Offset: 0x002E7FE4
			// (set) Token: 0x0600BD89 RID: 48521 RVA: 0x0005CC04 File Offset: 0x0005AE04
			public unsafe static float DensityMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_DensityMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_DensityMax, (void*)(&value));
				}
			}

			// Token: 0x17003AD8 RID: 15064
			// (get) Token: 0x0600BD8A RID: 48522 RVA: 0x002E9E00 File Offset: 0x002E8000
			// (set) Token: 0x0600BD8B RID: 48523 RVA: 0x0005CC12 File Offset: 0x0005AE12
			public unsafe static MinMaxRangeFloat SpawnDistanceRangeDefault
			{
				get
				{
					MinMaxRangeFloat result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_SpawnDistanceRangeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_SpawnDistanceRangeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AD9 RID: 15065
			// (get) Token: 0x0600BD8C RID: 48524 RVA: 0x002E9E1C File Offset: 0x002E801C
			// (set) Token: 0x0600BD8D RID: 48525 RVA: 0x0005CC20 File Offset: 0x0005AE20
			public unsafe static bool CullingEnabledDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_CullingEnabledDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_CullingEnabledDefault, (void*)(&value));
				}
			}

			// Token: 0x17003ADA RID: 15066
			// (get) Token: 0x0600BD8E RID: 48526 RVA: 0x002E9E38 File Offset: 0x002E8038
			// (set) Token: 0x0600BD8F RID: 48527 RVA: 0x0005CC2E File Offset: 0x0005AE2E
			public unsafe static float CullingMaxDistanceDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_CullingMaxDistanceDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_CullingMaxDistanceDefault, (void*)(&value));
				}
			}

			// Token: 0x17003ADB RID: 15067
			// (get) Token: 0x0600BD90 RID: 48528 RVA: 0x002E9E54 File Offset: 0x002E8054
			// (set) Token: 0x0600BD91 RID: 48529 RVA: 0x0005CC3C File Offset: 0x0005AE3C
			public unsafe static float CullingMaxDistanceMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_CullingMaxDistanceMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_CullingMaxDistanceMin, (void*)(&value));
				}
			}

			// Token: 0x0400804F RID: 32847
			private static readonly IntPtr NativeFieldInfoPtr_AlphaDefault;

			// Token: 0x04008050 RID: 32848
			private static readonly IntPtr NativeFieldInfoPtr_SizeDefault;

			// Token: 0x04008051 RID: 32849
			private static readonly IntPtr NativeFieldInfoPtr_DirectionDefault;

			// Token: 0x04008052 RID: 32850
			private static readonly IntPtr NativeFieldInfoPtr_VelocityDefault;

			// Token: 0x04008053 RID: 32851
			private static readonly IntPtr NativeFieldInfoPtr_DensityDefault;

			// Token: 0x04008054 RID: 32852
			private static readonly IntPtr NativeFieldInfoPtr_DensityMin;

			// Token: 0x04008055 RID: 32853
			private static readonly IntPtr NativeFieldInfoPtr_DensityMax;

			// Token: 0x04008056 RID: 32854
			private static readonly IntPtr NativeFieldInfoPtr_SpawnDistanceRangeDefault;

			// Token: 0x04008057 RID: 32855
			private static readonly IntPtr NativeFieldInfoPtr_CullingEnabledDefault;

			// Token: 0x04008058 RID: 32856
			private static readonly IntPtr NativeFieldInfoPtr_CullingMaxDistanceDefault;

			// Token: 0x04008059 RID: 32857
			private static readonly IntPtr NativeFieldInfoPtr_CullingMaxDistanceMin;
		}

		// Token: 0x02000811 RID: 2065
		public static class DynOcclusion : Il2CppSystem.Object
		{
			// Token: 0x0600BD92 RID: 48530 RVA: 0x002E9E70 File Offset: 0x002E8070
			// Note: this type is marked as 'beforefieldinit'.
			static DynOcclusion()
			{
				Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "DynOcclusion");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr);
				Consts.DynOcclusion.NativeFieldInfoPtr_LayerMaskDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "LayerMaskDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_UpdateRateDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "UpdateRateDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_WaitFramesCountDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "WaitFramesCountDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingDimensionsDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingDimensionsDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingConsiderTriggersDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingConsiderTriggersDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinOccluderAreaDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingMinOccluderAreaDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingMinSurfaceRatioDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingMinSurfaceRatioMin");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingMinSurfaceRatioMax");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceDotDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingMaxSurfaceDotDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceAngleMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingMaxSurfaceAngleMin");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceAngleMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingMaxSurfaceAngleMax");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingPlaneAlignmentDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingPlaneAlignmentDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingPlaneOffsetDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingPlaneOffsetDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingFadeDistanceToSurfaceDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingFadeDistanceToSurfaceDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferDepthMapResolutionDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "DepthBufferDepthMapResolutionDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferOcclusionCullingDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "DepthBufferOcclusionCullingDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferFadeDistanceToSurfaceDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "DepthBufferFadeDistanceToSurfaceDefault");
			}

			// Token: 0x0600BD93 RID: 48531 RVA: 0x0005CC4A File Offset: 0x0005AE4A
			public DynOcclusion(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003ADC RID: 15068
			// (get) Token: 0x0600BD94 RID: 48532 RVA: 0x002EA004 File Offset: 0x002E8204
			// (set) Token: 0x0600BD95 RID: 48533 RVA: 0x0005CC53 File Offset: 0x0005AE53
			public unsafe static LayerMask LayerMaskDefault
			{
				get
				{
					LayerMask result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_LayerMaskDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_LayerMaskDefault, (void*)(&value));
				}
			}

			// Token: 0x17003ADD RID: 15069
			// (get) Token: 0x0600BD96 RID: 48534 RVA: 0x002EA020 File Offset: 0x002E8220
			// (set) Token: 0x0600BD97 RID: 48535 RVA: 0x0005CC61 File Offset: 0x0005AE61
			public unsafe static DynamicOcclusionUpdateRate UpdateRateDefault
			{
				get
				{
					DynamicOcclusionUpdateRate result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_UpdateRateDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_UpdateRateDefault, (void*)(&value));
				}
			}

			// Token: 0x17003ADE RID: 15070
			// (get) Token: 0x0600BD98 RID: 48536 RVA: 0x002EA03C File Offset: 0x002E823C
			// (set) Token: 0x0600BD99 RID: 48537 RVA: 0x0005CC6F File Offset: 0x0005AE6F
			public unsafe static int WaitFramesCountDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_WaitFramesCountDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_WaitFramesCountDefault, (void*)(&value));
				}
			}

			// Token: 0x17003ADF RID: 15071
			// (get) Token: 0x0600BD9A RID: 48538 RVA: 0x002EA058 File Offset: 0x002E8258
			// (set) Token: 0x0600BD9B RID: 48539 RVA: 0x0005CC7D File Offset: 0x0005AE7D
			public unsafe static Dimensions RaycastingDimensionsDefault
			{
				get
				{
					Dimensions result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingDimensionsDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingDimensionsDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AE0 RID: 15072
			// (get) Token: 0x0600BD9C RID: 48540 RVA: 0x002EA074 File Offset: 0x002E8274
			// (set) Token: 0x0600BD9D RID: 48541 RVA: 0x0005CC8B File Offset: 0x0005AE8B
			public unsafe static bool RaycastingConsiderTriggersDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingConsiderTriggersDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingConsiderTriggersDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AE1 RID: 15073
			// (get) Token: 0x0600BD9E RID: 48542 RVA: 0x002EA090 File Offset: 0x002E8290
			// (set) Token: 0x0600BD9F RID: 48543 RVA: 0x0005CC99 File Offset: 0x0005AE99
			public unsafe static float RaycastingMinOccluderAreaDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinOccluderAreaDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinOccluderAreaDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AE2 RID: 15074
			// (get) Token: 0x0600BDA0 RID: 48544 RVA: 0x002EA0AC File Offset: 0x002E82AC
			// (set) Token: 0x0600BDA1 RID: 48545 RVA: 0x0005CCA7 File Offset: 0x0005AEA7
			public unsafe static float RaycastingMinSurfaceRatioDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AE3 RID: 15075
			// (get) Token: 0x0600BDA2 RID: 48546 RVA: 0x002EA0C8 File Offset: 0x002E82C8
			// (set) Token: 0x0600BDA3 RID: 48547 RVA: 0x0005CCB5 File Offset: 0x0005AEB5
			public unsafe static float RaycastingMinSurfaceRatioMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioMin, (void*)(&value));
				}
			}

			// Token: 0x17003AE4 RID: 15076
			// (get) Token: 0x0600BDA4 RID: 48548 RVA: 0x002EA0E4 File Offset: 0x002E82E4
			// (set) Token: 0x0600BDA5 RID: 48549 RVA: 0x0005CCC3 File Offset: 0x0005AEC3
			public unsafe static float RaycastingMinSurfaceRatioMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioMax, (void*)(&value));
				}
			}

			// Token: 0x17003AE5 RID: 15077
			// (get) Token: 0x0600BDA6 RID: 48550 RVA: 0x002EA100 File Offset: 0x002E8300
			// (set) Token: 0x0600BDA7 RID: 48551 RVA: 0x0005CCD1 File Offset: 0x0005AED1
			public unsafe static float RaycastingMaxSurfaceDotDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceDotDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceDotDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AE6 RID: 15078
			// (get) Token: 0x0600BDA8 RID: 48552 RVA: 0x002EA11C File Offset: 0x002E831C
			// (set) Token: 0x0600BDA9 RID: 48553 RVA: 0x0005CCDF File Offset: 0x0005AEDF
			public unsafe static float RaycastingMaxSurfaceAngleMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceAngleMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceAngleMin, (void*)(&value));
				}
			}

			// Token: 0x17003AE7 RID: 15079
			// (get) Token: 0x0600BDAA RID: 48554 RVA: 0x002EA138 File Offset: 0x002E8338
			// (set) Token: 0x0600BDAB RID: 48555 RVA: 0x0005CCED File Offset: 0x0005AEED
			public unsafe static float RaycastingMaxSurfaceAngleMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceAngleMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceAngleMax, (void*)(&value));
				}
			}

			// Token: 0x17003AE8 RID: 15080
			// (get) Token: 0x0600BDAC RID: 48556 RVA: 0x002EA154 File Offset: 0x002E8354
			// (set) Token: 0x0600BDAD RID: 48557 RVA: 0x0005CCFB File Offset: 0x0005AEFB
			public unsafe static PlaneAlignment RaycastingPlaneAlignmentDefault
			{
				get
				{
					PlaneAlignment result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingPlaneAlignmentDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingPlaneAlignmentDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AE9 RID: 15081
			// (get) Token: 0x0600BDAE RID: 48558 RVA: 0x002EA170 File Offset: 0x002E8370
			// (set) Token: 0x0600BDAF RID: 48559 RVA: 0x0005CD09 File Offset: 0x0005AF09
			public unsafe static float RaycastingPlaneOffsetDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingPlaneOffsetDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingPlaneOffsetDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AEA RID: 15082
			// (get) Token: 0x0600BDB0 RID: 48560 RVA: 0x002EA18C File Offset: 0x002E838C
			// (set) Token: 0x0600BDB1 RID: 48561 RVA: 0x0005CD17 File Offset: 0x0005AF17
			public unsafe static float RaycastingFadeDistanceToSurfaceDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingFadeDistanceToSurfaceDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingFadeDistanceToSurfaceDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AEB RID: 15083
			// (get) Token: 0x0600BDB2 RID: 48562 RVA: 0x002EA1A8 File Offset: 0x002E83A8
			// (set) Token: 0x0600BDB3 RID: 48563 RVA: 0x0005CD25 File Offset: 0x0005AF25
			public unsafe static int DepthBufferDepthMapResolutionDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferDepthMapResolutionDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferDepthMapResolutionDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AEC RID: 15084
			// (get) Token: 0x0600BDB4 RID: 48564 RVA: 0x002EA1C4 File Offset: 0x002E83C4
			// (set) Token: 0x0600BDB5 RID: 48565 RVA: 0x0005CD33 File Offset: 0x0005AF33
			public unsafe static bool DepthBufferOcclusionCullingDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferOcclusionCullingDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferOcclusionCullingDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AED RID: 15085
			// (get) Token: 0x0600BDB6 RID: 48566 RVA: 0x002EA1E0 File Offset: 0x002E83E0
			// (set) Token: 0x0600BDB7 RID: 48567 RVA: 0x0005CD41 File Offset: 0x0005AF41
			public unsafe static float DepthBufferFadeDistanceToSurfaceDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferFadeDistanceToSurfaceDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferFadeDistanceToSurfaceDefault, (void*)(&value));
				}
			}

			// Token: 0x0400805A RID: 32858
			private static readonly IntPtr NativeFieldInfoPtr_LayerMaskDefault;

			// Token: 0x0400805B RID: 32859
			private static readonly IntPtr NativeFieldInfoPtr_UpdateRateDefault;

			// Token: 0x0400805C RID: 32860
			private static readonly IntPtr NativeFieldInfoPtr_WaitFramesCountDefault;

			// Token: 0x0400805D RID: 32861
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingDimensionsDefault;

			// Token: 0x0400805E RID: 32862
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingConsiderTriggersDefault;

			// Token: 0x0400805F RID: 32863
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingMinOccluderAreaDefault;

			// Token: 0x04008060 RID: 32864
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingMinSurfaceRatioDefault;

			// Token: 0x04008061 RID: 32865
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingMinSurfaceRatioMin;

			// Token: 0x04008062 RID: 32866
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingMinSurfaceRatioMax;

			// Token: 0x04008063 RID: 32867
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingMaxSurfaceDotDefault;

			// Token: 0x04008064 RID: 32868
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingMaxSurfaceAngleMin;

			// Token: 0x04008065 RID: 32869
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingMaxSurfaceAngleMax;

			// Token: 0x04008066 RID: 32870
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingPlaneAlignmentDefault;

			// Token: 0x04008067 RID: 32871
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingPlaneOffsetDefault;

			// Token: 0x04008068 RID: 32872
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingFadeDistanceToSurfaceDefault;

			// Token: 0x04008069 RID: 32873
			private static readonly IntPtr NativeFieldInfoPtr_DepthBufferDepthMapResolutionDefault;

			// Token: 0x0400806A RID: 32874
			private static readonly IntPtr NativeFieldInfoPtr_DepthBufferOcclusionCullingDefault;

			// Token: 0x0400806B RID: 32875
			private static readonly IntPtr NativeFieldInfoPtr_DepthBufferFadeDistanceToSurfaceDefault;
		}

		// Token: 0x02000812 RID: 2066
		public static class Effects : Il2CppSystem.Object
		{
			// Token: 0x0600BDB8 RID: 48568 RVA: 0x002EA1FC File Offset: 0x002E83FC
			// Note: this type is marked as 'beforefieldinit'.
			static Effects()
			{
				Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "Effects");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr);
				Consts.Effects.NativeFieldInfoPtr_ComponentsToChangeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "ComponentsToChangeDefault");
				Consts.Effects.NativeFieldInfoPtr_RestoreIntensityOnDisableDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "RestoreIntensityOnDisableDefault");
				Consts.Effects.NativeFieldInfoPtr_FrequencyDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "FrequencyDefault");
				Consts.Effects.NativeFieldInfoPtr_PerformPausesDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "PerformPausesDefault");
				Consts.Effects.NativeFieldInfoPtr_RestoreIntensityOnPauseDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "RestoreIntensityOnPauseDefault");
				Consts.Effects.NativeFieldInfoPtr_FlickeringDurationDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "FlickeringDurationDefault");
				Consts.Effects.NativeFieldInfoPtr_PauseDurationDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "PauseDurationDefault");
				Consts.Effects.NativeFieldInfoPtr_IntensityAmplitudeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "IntensityAmplitudeDefault");
				Consts.Effects.NativeFieldInfoPtr_SmoothingDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "SmoothingDefault");
			}

			// Token: 0x0600BDB9 RID: 48569 RVA: 0x0005CD4F File Offset: 0x0005AF4F
			public Effects(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003AEE RID: 15086
			// (get) Token: 0x0600BDBA RID: 48570 RVA: 0x002EA2DC File Offset: 0x002E84DC
			// (set) Token: 0x0600BDBB RID: 48571 RVA: 0x0005CD58 File Offset: 0x0005AF58
			public unsafe static EffectAbstractBase.ComponentsToChange ComponentsToChangeDefault
			{
				get
				{
					EffectAbstractBase.ComponentsToChange result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_ComponentsToChangeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_ComponentsToChangeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AEF RID: 15087
			// (get) Token: 0x0600BDBC RID: 48572 RVA: 0x002EA2F8 File Offset: 0x002E84F8
			// (set) Token: 0x0600BDBD RID: 48573 RVA: 0x0005CD66 File Offset: 0x0005AF66
			public unsafe static bool RestoreIntensityOnDisableDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_RestoreIntensityOnDisableDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_RestoreIntensityOnDisableDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AF0 RID: 15088
			// (get) Token: 0x0600BDBE RID: 48574 RVA: 0x002EA314 File Offset: 0x002E8514
			// (set) Token: 0x0600BDBF RID: 48575 RVA: 0x0005CD74 File Offset: 0x0005AF74
			public unsafe static float FrequencyDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_FrequencyDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_FrequencyDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AF1 RID: 15089
			// (get) Token: 0x0600BDC0 RID: 48576 RVA: 0x002EA330 File Offset: 0x002E8530
			// (set) Token: 0x0600BDC1 RID: 48577 RVA: 0x0005CD82 File Offset: 0x0005AF82
			public unsafe static bool PerformPausesDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_PerformPausesDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_PerformPausesDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AF2 RID: 15090
			// (get) Token: 0x0600BDC2 RID: 48578 RVA: 0x002EA34C File Offset: 0x002E854C
			// (set) Token: 0x0600BDC3 RID: 48579 RVA: 0x0005CD90 File Offset: 0x0005AF90
			public unsafe static bool RestoreIntensityOnPauseDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_RestoreIntensityOnPauseDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_RestoreIntensityOnPauseDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AF3 RID: 15091
			// (get) Token: 0x0600BDC4 RID: 48580 RVA: 0x002EA368 File Offset: 0x002E8568
			// (set) Token: 0x0600BDC5 RID: 48581 RVA: 0x0005CD9E File Offset: 0x0005AF9E
			public unsafe static MinMaxRangeFloat FlickeringDurationDefault
			{
				get
				{
					MinMaxRangeFloat result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_FlickeringDurationDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_FlickeringDurationDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AF4 RID: 15092
			// (get) Token: 0x0600BDC6 RID: 48582 RVA: 0x002EA384 File Offset: 0x002E8584
			// (set) Token: 0x0600BDC7 RID: 48583 RVA: 0x0005CDAC File Offset: 0x0005AFAC
			public unsafe static MinMaxRangeFloat PauseDurationDefault
			{
				get
				{
					MinMaxRangeFloat result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_PauseDurationDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_PauseDurationDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AF5 RID: 15093
			// (get) Token: 0x0600BDC8 RID: 48584 RVA: 0x002EA3A0 File Offset: 0x002E85A0
			// (set) Token: 0x0600BDC9 RID: 48585 RVA: 0x0005CDBA File Offset: 0x0005AFBA
			public unsafe static MinMaxRangeFloat IntensityAmplitudeDefault
			{
				get
				{
					MinMaxRangeFloat result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_IntensityAmplitudeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_IntensityAmplitudeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AF6 RID: 15094
			// (get) Token: 0x0600BDCA RID: 48586 RVA: 0x002EA3BC File Offset: 0x002E85BC
			// (set) Token: 0x0600BDCB RID: 48587 RVA: 0x0005CDC8 File Offset: 0x0005AFC8
			public unsafe static float SmoothingDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_SmoothingDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_SmoothingDefault, (void*)(&value));
				}
			}

			// Token: 0x0400806C RID: 32876
			private static readonly IntPtr NativeFieldInfoPtr_ComponentsToChangeDefault;

			// Token: 0x0400806D RID: 32877
			private static readonly IntPtr NativeFieldInfoPtr_RestoreIntensityOnDisableDefault;

			// Token: 0x0400806E RID: 32878
			private static readonly IntPtr NativeFieldInfoPtr_FrequencyDefault;

			// Token: 0x0400806F RID: 32879
			private static readonly IntPtr NativeFieldInfoPtr_PerformPausesDefault;

			// Token: 0x04008070 RID: 32880
			private static readonly IntPtr NativeFieldInfoPtr_RestoreIntensityOnPauseDefault;

			// Token: 0x04008071 RID: 32881
			private static readonly IntPtr NativeFieldInfoPtr_FlickeringDurationDefault;

			// Token: 0x04008072 RID: 32882
			private static readonly IntPtr NativeFieldInfoPtr_PauseDurationDefault;

			// Token: 0x04008073 RID: 32883
			private static readonly IntPtr NativeFieldInfoPtr_IntensityAmplitudeDefault;

			// Token: 0x04008074 RID: 32884
			private static readonly IntPtr NativeFieldInfoPtr_SmoothingDefault;
		}

		// Token: 0x02000813 RID: 2067
		public static class Shadow : Il2CppSystem.Object
		{
			// Token: 0x0600BDCC RID: 48588 RVA: 0x002EA3D8 File Offset: 0x002E85D8
			// Note: this type is marked as 'beforefieldinit'.
			static Shadow()
			{
				Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "Shadow");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr);
				Consts.Shadow.NativeFieldInfoPtr_StrengthDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, "StrengthDefault");
				Consts.Shadow.NativeFieldInfoPtr_StrengthMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, "StrengthMin");
				Consts.Shadow.NativeFieldInfoPtr_StrengthMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, "StrengthMax");
				Consts.Shadow.NativeFieldInfoPtr_LayerMaskDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, "LayerMaskDefault");
				Consts.Shadow.NativeFieldInfoPtr_UpdateRateDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, "UpdateRateDefault");
				Consts.Shadow.NativeFieldInfoPtr_WaitFramesCountDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, "WaitFramesCountDefault");
				Consts.Shadow.NativeFieldInfoPtr_DepthMapResolutionDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, "DepthMapResolutionDefault");
				Consts.Shadow.NativeFieldInfoPtr_OcclusionCullingDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, "OcclusionCullingDefault");
				Consts.Shadow.NativeMethodInfoPtr_GetErrorChangeRuntimeDepthMapResolution_Public_Static_String_VolumetricShadowHD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, 100664280);
			}

			// Token: 0x0600BDCD RID: 48589 RVA: 0x002EA4B8 File Offset: 0x002E86B8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 80042, RefRangeEnd = 80043, XrefRangeStart = 80034, XrefRangeEnd = 80042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string GetErrorChangeRuntimeDepthMapResolution(VolumetricShadowHD comp)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Consts.Shadow.NativeMethodInfoPtr_GetErrorChangeRuntimeDepthMapResolution_Public_Static_String_VolumetricShadowHD_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600BDCE RID: 48590 RVA: 0x0005CDD6 File Offset: 0x0005AFD6
			public Shadow(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003AF7 RID: 15095
			// (get) Token: 0x0600BDCF RID: 48591 RVA: 0x002EA4F4 File Offset: 0x002E86F4
			// (set) Token: 0x0600BDD0 RID: 48592 RVA: 0x0005CDDF File Offset: 0x0005AFDF
			public unsafe static float StrengthDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Shadow.NativeFieldInfoPtr_StrengthDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Shadow.NativeFieldInfoPtr_StrengthDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AF8 RID: 15096
			// (get) Token: 0x0600BDD1 RID: 48593 RVA: 0x002EA510 File Offset: 0x002E8710
			// (set) Token: 0x0600BDD2 RID: 48594 RVA: 0x0005CDED File Offset: 0x0005AFED
			public unsafe static float StrengthMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Shadow.NativeFieldInfoPtr_StrengthMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Shadow.NativeFieldInfoPtr_StrengthMin, (void*)(&value));
				}
			}

			// Token: 0x17003AF9 RID: 15097
			// (get) Token: 0x0600BDD3 RID: 48595 RVA: 0x002EA52C File Offset: 0x002E872C
			// (set) Token: 0x0600BDD4 RID: 48596 RVA: 0x0005CDFB File Offset: 0x0005AFFB
			public unsafe static float StrengthMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Shadow.NativeFieldInfoPtr_StrengthMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Shadow.NativeFieldInfoPtr_StrengthMax, (void*)(&value));
				}
			}

			// Token: 0x17003AFA RID: 15098
			// (get) Token: 0x0600BDD5 RID: 48597 RVA: 0x002EA548 File Offset: 0x002E8748
			// (set) Token: 0x0600BDD6 RID: 48598 RVA: 0x0005CE09 File Offset: 0x0005B009
			public unsafe static LayerMask LayerMaskDefault
			{
				get
				{
					LayerMask result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Shadow.NativeFieldInfoPtr_LayerMaskDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Shadow.NativeFieldInfoPtr_LayerMaskDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AFB RID: 15099
			// (get) Token: 0x0600BDD7 RID: 48599 RVA: 0x002EA564 File Offset: 0x002E8764
			// (set) Token: 0x0600BDD8 RID: 48600 RVA: 0x0005CE17 File Offset: 0x0005B017
			public unsafe static ShadowUpdateRate UpdateRateDefault
			{
				get
				{
					ShadowUpdateRate result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Shadow.NativeFieldInfoPtr_UpdateRateDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Shadow.NativeFieldInfoPtr_UpdateRateDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AFC RID: 15100
			// (get) Token: 0x0600BDD9 RID: 48601 RVA: 0x002EA580 File Offset: 0x002E8780
			// (set) Token: 0x0600BDDA RID: 48602 RVA: 0x0005CE25 File Offset: 0x0005B025
			public unsafe static int WaitFramesCountDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Shadow.NativeFieldInfoPtr_WaitFramesCountDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Shadow.NativeFieldInfoPtr_WaitFramesCountDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AFD RID: 15101
			// (get) Token: 0x0600BDDB RID: 48603 RVA: 0x002EA59C File Offset: 0x002E879C
			// (set) Token: 0x0600BDDC RID: 48604 RVA: 0x0005CE33 File Offset: 0x0005B033
			public unsafe static int DepthMapResolutionDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Shadow.NativeFieldInfoPtr_DepthMapResolutionDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Shadow.NativeFieldInfoPtr_DepthMapResolutionDefault, (void*)(&value));
				}
			}

			// Token: 0x17003AFE RID: 15102
			// (get) Token: 0x0600BDDD RID: 48605 RVA: 0x002EA5B8 File Offset: 0x002E87B8
			// (set) Token: 0x0600BDDE RID: 48606 RVA: 0x0005CE41 File Offset: 0x0005B041
			public unsafe static bool OcclusionCullingDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Shadow.NativeFieldInfoPtr_OcclusionCullingDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Shadow.NativeFieldInfoPtr_OcclusionCullingDefault, (void*)(&value));
				}
			}

			// Token: 0x04008075 RID: 32885
			private static readonly IntPtr NativeFieldInfoPtr_StrengthDefault;

			// Token: 0x04008076 RID: 32886
			private static readonly IntPtr NativeFieldInfoPtr_StrengthMin;

			// Token: 0x04008077 RID: 32887
			private static readonly IntPtr NativeFieldInfoPtr_StrengthMax;

			// Token: 0x04008078 RID: 32888
			private static readonly IntPtr NativeFieldInfoPtr_LayerMaskDefault;

			// Token: 0x04008079 RID: 32889
			private static readonly IntPtr NativeFieldInfoPtr_UpdateRateDefault;

			// Token: 0x0400807A RID: 32890
			private static readonly IntPtr NativeFieldInfoPtr_WaitFramesCountDefault;

			// Token: 0x0400807B RID: 32891
			private static readonly IntPtr NativeFieldInfoPtr_DepthMapResolutionDefault;

			// Token: 0x0400807C RID: 32892
			private static readonly IntPtr NativeFieldInfoPtr_OcclusionCullingDefault;

			// Token: 0x0400807D RID: 32893
			private static readonly IntPtr NativeMethodInfoPtr_GetErrorChangeRuntimeDepthMapResolution_Public_Static_String_VolumetricShadowHD_0;
		}

		// Token: 0x02000814 RID: 2068
		public static class Cookie : Il2CppSystem.Object
		{
			// Token: 0x0600BDDF RID: 48607 RVA: 0x002EA5D4 File Offset: 0x002E87D4
			// Note: this type is marked as 'beforefieldinit'.
			static Cookie()
			{
				Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "Cookie");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr);
				Consts.Cookie.NativeFieldInfoPtr_ContributionDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "ContributionDefault");
				Consts.Cookie.NativeFieldInfoPtr_ContributionMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "ContributionMin");
				Consts.Cookie.NativeFieldInfoPtr_ContributionMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "ContributionMax");
				Consts.Cookie.NativeFieldInfoPtr_CookieTextureDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "CookieTextureDefault");
				Consts.Cookie.NativeFieldInfoPtr_ChannelDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "ChannelDefault");
				Consts.Cookie.NativeFieldInfoPtr_NegativeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "NegativeDefault");
				Consts.Cookie.NativeFieldInfoPtr_TranslationDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "TranslationDefault");
				Consts.Cookie.NativeFieldInfoPtr_RotationDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "RotationDefault");
				Consts.Cookie.NativeFieldInfoPtr_ScaleDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "ScaleDefault");
			}

			// Token: 0x0600BDE0 RID: 48608 RVA: 0x0005CE4F File Offset: 0x0005B04F
			public Cookie(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003AFF RID: 15103
			// (get) Token: 0x0600BDE1 RID: 48609 RVA: 0x002EA6B4 File Offset: 0x002E88B4
			// (set) Token: 0x0600BDE2 RID: 48610 RVA: 0x0005CE58 File Offset: 0x0005B058
			public unsafe static float ContributionDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_ContributionDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_ContributionDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B00 RID: 15104
			// (get) Token: 0x0600BDE3 RID: 48611 RVA: 0x002EA6D0 File Offset: 0x002E88D0
			// (set) Token: 0x0600BDE4 RID: 48612 RVA: 0x0005CE66 File Offset: 0x0005B066
			public unsafe static float ContributionMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_ContributionMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_ContributionMin, (void*)(&value));
				}
			}

			// Token: 0x17003B01 RID: 15105
			// (get) Token: 0x0600BDE5 RID: 48613 RVA: 0x002EA6EC File Offset: 0x002E88EC
			// (set) Token: 0x0600BDE6 RID: 48614 RVA: 0x0005CE74 File Offset: 0x0005B074
			public unsafe static float ContributionMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_ContributionMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_ContributionMax, (void*)(&value));
				}
			}

			// Token: 0x17003B02 RID: 15106
			// (get) Token: 0x0600BDE7 RID: 48615 RVA: 0x002EA708 File Offset: 0x002E8908
			// (set) Token: 0x0600BDE8 RID: 48616 RVA: 0x0005CE82 File Offset: 0x0005B082
			public unsafe static Texture CookieTextureDefault
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_CookieTextureDefault, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_CookieTextureDefault, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B03 RID: 15107
			// (get) Token: 0x0600BDE9 RID: 48617 RVA: 0x002EA730 File Offset: 0x002E8930
			// (set) Token: 0x0600BDEA RID: 48618 RVA: 0x0005CE94 File Offset: 0x0005B094
			public unsafe static CookieChannel ChannelDefault
			{
				get
				{
					CookieChannel result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_ChannelDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_ChannelDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B04 RID: 15108
			// (get) Token: 0x0600BDEB RID: 48619 RVA: 0x002EA74C File Offset: 0x002E894C
			// (set) Token: 0x0600BDEC RID: 48620 RVA: 0x0005CEA2 File Offset: 0x0005B0A2
			public unsafe static bool NegativeDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_NegativeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_NegativeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B05 RID: 15109
			// (get) Token: 0x0600BDED RID: 48621 RVA: 0x002EA768 File Offset: 0x002E8968
			// (set) Token: 0x0600BDEE RID: 48622 RVA: 0x0005CEB0 File Offset: 0x0005B0B0
			public unsafe static Vector2 TranslationDefault
			{
				get
				{
					Vector2 result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_TranslationDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_TranslationDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B06 RID: 15110
			// (get) Token: 0x0600BDEF RID: 48623 RVA: 0x002EA784 File Offset: 0x002E8984
			// (set) Token: 0x0600BDF0 RID: 48624 RVA: 0x0005CEBE File Offset: 0x0005B0BE
			public unsafe static float RotationDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_RotationDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_RotationDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B07 RID: 15111
			// (get) Token: 0x0600BDF1 RID: 48625 RVA: 0x002EA7A0 File Offset: 0x002E89A0
			// (set) Token: 0x0600BDF2 RID: 48626 RVA: 0x0005CECC File Offset: 0x0005B0CC
			public unsafe static Vector2 ScaleDefault
			{
				get
				{
					Vector2 result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_ScaleDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_ScaleDefault, (void*)(&value));
				}
			}

			// Token: 0x0400807E RID: 32894
			private static readonly IntPtr NativeFieldInfoPtr_ContributionDefault;

			// Token: 0x0400807F RID: 32895
			private static readonly IntPtr NativeFieldInfoPtr_ContributionMin;

			// Token: 0x04008080 RID: 32896
			private static readonly IntPtr NativeFieldInfoPtr_ContributionMax;

			// Token: 0x04008081 RID: 32897
			private static readonly IntPtr NativeFieldInfoPtr_CookieTextureDefault;

			// Token: 0x04008082 RID: 32898
			private static readonly IntPtr NativeFieldInfoPtr_ChannelDefault;

			// Token: 0x04008083 RID: 32899
			private static readonly IntPtr NativeFieldInfoPtr_NegativeDefault;

			// Token: 0x04008084 RID: 32900
			private static readonly IntPtr NativeFieldInfoPtr_TranslationDefault;

			// Token: 0x04008085 RID: 32901
			private static readonly IntPtr NativeFieldInfoPtr_RotationDefault;

			// Token: 0x04008086 RID: 32902
			private static readonly IntPtr NativeFieldInfoPtr_ScaleDefault;
		}

		// Token: 0x02000815 RID: 2069
		public static class Config : Il2CppSystem.Object
		{
			// Token: 0x0600BDF3 RID: 48627 RVA: 0x002EA7BC File Offset: 0x002E89BC
			// Note: this type is marked as 'beforefieldinit'.
			static Config()
			{
				Il2CppClassPointerStore<Consts.Config>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "Config");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr);
				Consts.Config.NativeFieldInfoPtr_GeometryOverrideLayerDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "GeometryOverrideLayerDefault");
				Consts.Config.NativeFieldInfoPtr_GeometryLayerIDDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "GeometryLayerIDDefault");
				Consts.Config.NativeFieldInfoPtr_GeometryTagDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "GeometryTagDefault");
				Consts.Config.NativeFieldInfoPtr_FadeOutCameraTagDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "FadeOutCameraTagDefault");
				Consts.Config.NativeFieldInfoPtr_GeometryRenderQueueDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "GeometryRenderQueueDefault");
				Consts.Config.NativeFieldInfoPtr_GeometryRenderPipelineDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "GeometryRenderPipelineDefault");
				Consts.Config.NativeFieldInfoPtr_GeometryRenderingModeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "GeometryRenderingModeDefault");
				Consts.Config.NativeFieldInfoPtr_Noise3DSizeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "Noise3DSizeDefault");
				Consts.Config.NativeFieldInfoPtr_DitheringFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "DitheringFactor");
				Consts.Config.NativeFieldInfoPtr_UseLightColorTemperatureDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "UseLightColorTemperatureDefault");
				Consts.Config.NativeFieldInfoPtr_FeatureEnabledDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "FeatureEnabledDefault");
				Consts.Config.NativeFieldInfoPtr_FeatureEnabledColorGradientDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "FeatureEnabledColorGradientDefault");
				Consts.Config.NativeFieldInfoPtr_SharedMeshSidesDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "SharedMeshSidesDefault");
				Consts.Config.NativeFieldInfoPtr_SharedMeshSidesMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "SharedMeshSidesMin");
				Consts.Config.NativeFieldInfoPtr_SharedMeshSidesMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "SharedMeshSidesMax");
				Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "SharedMeshSegmentsDefault");
				Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "SharedMeshSegmentsMin");
				Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "SharedMeshSegmentsMax");
			}

			// Token: 0x0600BDF4 RID: 48628 RVA: 0x0005CEDA File Offset: 0x0005B0DA
			public Config(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B08 RID: 15112
			// (get) Token: 0x0600BDF5 RID: 48629 RVA: 0x002EA950 File Offset: 0x002E8B50
			// (set) Token: 0x0600BDF6 RID: 48630 RVA: 0x0005CEE3 File Offset: 0x0005B0E3
			public unsafe static bool GeometryOverrideLayerDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_GeometryOverrideLayerDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_GeometryOverrideLayerDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B09 RID: 15113
			// (get) Token: 0x0600BDF7 RID: 48631 RVA: 0x002EA96C File Offset: 0x002E8B6C
			// (set) Token: 0x0600BDF8 RID: 48632 RVA: 0x0005CEF1 File Offset: 0x0005B0F1
			public unsafe static int GeometryLayerIDDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_GeometryLayerIDDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_GeometryLayerIDDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B0A RID: 15114
			// (get) Token: 0x0600BDF9 RID: 48633 RVA: 0x002EA988 File Offset: 0x002E8B88
			// (set) Token: 0x0600BDFA RID: 48634 RVA: 0x0005CEFF File Offset: 0x0005B0FF
			public unsafe static string GeometryTagDefault
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_GeometryTagDefault, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_GeometryTagDefault, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003B0B RID: 15115
			// (get) Token: 0x0600BDFB RID: 48635 RVA: 0x002EA9A8 File Offset: 0x002E8BA8
			// (set) Token: 0x0600BDFC RID: 48636 RVA: 0x0005CF11 File Offset: 0x0005B111
			public unsafe static string FadeOutCameraTagDefault
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_FadeOutCameraTagDefault, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_FadeOutCameraTagDefault, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003B0C RID: 15116
			// (get) Token: 0x0600BDFD RID: 48637 RVA: 0x002EA9C8 File Offset: 0x002E8BC8
			// (set) Token: 0x0600BDFE RID: 48638 RVA: 0x0005CF23 File Offset: 0x0005B123
			public unsafe static RenderQueue GeometryRenderQueueDefault
			{
				get
				{
					RenderQueue result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_GeometryRenderQueueDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_GeometryRenderQueueDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B0D RID: 15117
			// (get) Token: 0x0600BDFF RID: 48639 RVA: 0x002EA9E4 File Offset: 0x002E8BE4
			// (set) Token: 0x0600BE00 RID: 48640 RVA: 0x0005CF31 File Offset: 0x0005B131
			public unsafe static RenderPipeline GeometryRenderPipelineDefault
			{
				get
				{
					RenderPipeline result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_GeometryRenderPipelineDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_GeometryRenderPipelineDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B0E RID: 15118
			// (get) Token: 0x0600BE01 RID: 48641 RVA: 0x002EAA00 File Offset: 0x002E8C00
			// (set) Token: 0x0600BE02 RID: 48642 RVA: 0x0005CF3F File Offset: 0x0005B13F
			public unsafe static RenderingMode GeometryRenderingModeDefault
			{
				get
				{
					RenderingMode result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_GeometryRenderingModeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_GeometryRenderingModeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B0F RID: 15119
			// (get) Token: 0x0600BE03 RID: 48643 RVA: 0x002EAA1C File Offset: 0x002E8C1C
			// (set) Token: 0x0600BE04 RID: 48644 RVA: 0x0005CF4D File Offset: 0x0005B14D
			public unsafe static int Noise3DSizeDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_Noise3DSizeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_Noise3DSizeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B10 RID: 15120
			// (get) Token: 0x0600BE05 RID: 48645 RVA: 0x002EAA38 File Offset: 0x002E8C38
			// (set) Token: 0x0600BE06 RID: 48646 RVA: 0x0005CF5B File Offset: 0x0005B15B
			public unsafe static float DitheringFactor
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_DitheringFactor, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_DitheringFactor, (void*)(&value));
				}
			}

			// Token: 0x17003B11 RID: 15121
			// (get) Token: 0x0600BE07 RID: 48647 RVA: 0x002EAA54 File Offset: 0x002E8C54
			// (set) Token: 0x0600BE08 RID: 48648 RVA: 0x0005CF69 File Offset: 0x0005B169
			public unsafe static bool UseLightColorTemperatureDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_UseLightColorTemperatureDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_UseLightColorTemperatureDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B12 RID: 15122
			// (get) Token: 0x0600BE09 RID: 48649 RVA: 0x002EAA70 File Offset: 0x002E8C70
			// (set) Token: 0x0600BE0A RID: 48650 RVA: 0x0005CF77 File Offset: 0x0005B177
			public unsafe static bool FeatureEnabledDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_FeatureEnabledDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_FeatureEnabledDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B13 RID: 15123
			// (get) Token: 0x0600BE0B RID: 48651 RVA: 0x002EAA8C File Offset: 0x002E8C8C
			// (set) Token: 0x0600BE0C RID: 48652 RVA: 0x0005CF85 File Offset: 0x0005B185
			public unsafe static FeatureEnabledColorGradient FeatureEnabledColorGradientDefault
			{
				get
				{
					FeatureEnabledColorGradient result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_FeatureEnabledColorGradientDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_FeatureEnabledColorGradientDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B14 RID: 15124
			// (get) Token: 0x0600BE0D RID: 48653 RVA: 0x002EAAA8 File Offset: 0x002E8CA8
			// (set) Token: 0x0600BE0E RID: 48654 RVA: 0x0005CF93 File Offset: 0x0005B193
			public unsafe static int SharedMeshSidesDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSidesDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSidesDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B15 RID: 15125
			// (get) Token: 0x0600BE0F RID: 48655 RVA: 0x002EAAC4 File Offset: 0x002E8CC4
			// (set) Token: 0x0600BE10 RID: 48656 RVA: 0x0005CFA1 File Offset: 0x0005B1A1
			public unsafe static int SharedMeshSidesMin
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSidesMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSidesMin, (void*)(&value));
				}
			}

			// Token: 0x17003B16 RID: 15126
			// (get) Token: 0x0600BE11 RID: 48657 RVA: 0x002EAAE0 File Offset: 0x002E8CE0
			// (set) Token: 0x0600BE12 RID: 48658 RVA: 0x0005CFAF File Offset: 0x0005B1AF
			public unsafe static int SharedMeshSidesMax
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSidesMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSidesMax, (void*)(&value));
				}
			}

			// Token: 0x17003B17 RID: 15127
			// (get) Token: 0x0600BE13 RID: 48659 RVA: 0x002EAAFC File Offset: 0x002E8CFC
			// (set) Token: 0x0600BE14 RID: 48660 RVA: 0x0005CFBD File Offset: 0x0005B1BD
			public unsafe static int SharedMeshSegmentsDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsDefault, (void*)(&value));
				}
			}

			// Token: 0x17003B18 RID: 15128
			// (get) Token: 0x0600BE15 RID: 48661 RVA: 0x002EAB18 File Offset: 0x002E8D18
			// (set) Token: 0x0600BE16 RID: 48662 RVA: 0x0005CFCB File Offset: 0x0005B1CB
			public unsafe static int SharedMeshSegmentsMin
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsMin, (void*)(&value));
				}
			}

			// Token: 0x17003B19 RID: 15129
			// (get) Token: 0x0600BE17 RID: 48663 RVA: 0x002EAB34 File Offset: 0x002E8D34
			// (set) Token: 0x0600BE18 RID: 48664 RVA: 0x0005CFD9 File Offset: 0x0005B1D9
			public unsafe static int SharedMeshSegmentsMax
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsMax, (void*)(&value));
				}
			}

			// Token: 0x04008087 RID: 32903
			private static readonly IntPtr NativeFieldInfoPtr_GeometryOverrideLayerDefault;

			// Token: 0x04008088 RID: 32904
			private static readonly IntPtr NativeFieldInfoPtr_GeometryLayerIDDefault;

			// Token: 0x04008089 RID: 32905
			private static readonly IntPtr NativeFieldInfoPtr_GeometryTagDefault;

			// Token: 0x0400808A RID: 32906
			private static readonly IntPtr NativeFieldInfoPtr_FadeOutCameraTagDefault;

			// Token: 0x0400808B RID: 32907
			private static readonly IntPtr NativeFieldInfoPtr_GeometryRenderQueueDefault;

			// Token: 0x0400808C RID: 32908
			private static readonly IntPtr NativeFieldInfoPtr_GeometryRenderPipelineDefault;

			// Token: 0x0400808D RID: 32909
			private static readonly IntPtr NativeFieldInfoPtr_GeometryRenderingModeDefault;

			// Token: 0x0400808E RID: 32910
			private static readonly IntPtr NativeFieldInfoPtr_Noise3DSizeDefault;

			// Token: 0x0400808F RID: 32911
			private static readonly IntPtr NativeFieldInfoPtr_DitheringFactor;

			// Token: 0x04008090 RID: 32912
			private static readonly IntPtr NativeFieldInfoPtr_UseLightColorTemperatureDefault;

			// Token: 0x04008091 RID: 32913
			private static readonly IntPtr NativeFieldInfoPtr_FeatureEnabledDefault;

			// Token: 0x04008092 RID: 32914
			private static readonly IntPtr NativeFieldInfoPtr_FeatureEnabledColorGradientDefault;

			// Token: 0x04008093 RID: 32915
			private static readonly IntPtr NativeFieldInfoPtr_SharedMeshSidesDefault;

			// Token: 0x04008094 RID: 32916
			private static readonly IntPtr NativeFieldInfoPtr_SharedMeshSidesMin;

			// Token: 0x04008095 RID: 32917
			private static readonly IntPtr NativeFieldInfoPtr_SharedMeshSidesMax;

			// Token: 0x04008096 RID: 32918
			private static readonly IntPtr NativeFieldInfoPtr_SharedMeshSegmentsDefault;

			// Token: 0x04008097 RID: 32919
			private static readonly IntPtr NativeFieldInfoPtr_SharedMeshSegmentsMin;

			// Token: 0x04008098 RID: 32920
			private static readonly IntPtr NativeFieldInfoPtr_SharedMeshSegmentsMax;

			// Token: 0x02000C22 RID: 3106
			public static class HD : Il2CppSystem.Object
			{
				// Token: 0x0600E0ED RID: 57581 RVA: 0x0034E454 File Offset: 0x0034C654
				// Note: this type is marked as 'beforefieldinit'.
				static HD()
				{
					Il2CppClassPointerStore<Consts.Config.HD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "HD");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Config.HD>.NativeClassPtr);
					Consts.Config.HD.NativeFieldInfoPtr_GeometryRenderQueueDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config.HD>.NativeClassPtr, "GeometryRenderQueueDefault");
					Consts.Config.HD.NativeFieldInfoPtr_CameraBlendingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config.HD>.NativeClassPtr, "CameraBlendingDistance");
					Consts.Config.HD.NativeFieldInfoPtr_RaymarchingQualitiesStepsMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config.HD>.NativeClassPtr, "RaymarchingQualitiesStepsMin");
				}

				// Token: 0x0600E0EE RID: 57582 RVA: 0x0006DA8A File Offset: 0x0006BC8A
				public HD(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045AE RID: 17838
				// (get) Token: 0x0600E0EF RID: 57583 RVA: 0x0034E4BC File Offset: 0x0034C6BC
				// (set) Token: 0x0600E0F0 RID: 57584 RVA: 0x0006DA93 File Offset: 0x0006BC93
				public unsafe static RenderQueue GeometryRenderQueueDefault
				{
					get
					{
						RenderQueue result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Config.HD.NativeFieldInfoPtr_GeometryRenderQueueDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Config.HD.NativeFieldInfoPtr_GeometryRenderQueueDefault, (void*)(&value));
					}
				}

				// Token: 0x170045AF RID: 17839
				// (get) Token: 0x0600E0F1 RID: 57585 RVA: 0x0034E4D8 File Offset: 0x0034C6D8
				// (set) Token: 0x0600E0F2 RID: 57586 RVA: 0x0006DAA1 File Offset: 0x0006BCA1
				public unsafe static float CameraBlendingDistance
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Config.HD.NativeFieldInfoPtr_CameraBlendingDistance, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Config.HD.NativeFieldInfoPtr_CameraBlendingDistance, (void*)(&value));
					}
				}

				// Token: 0x170045B0 RID: 17840
				// (get) Token: 0x0600E0F3 RID: 57587 RVA: 0x0034E4F4 File Offset: 0x0034C6F4
				// (set) Token: 0x0600E0F4 RID: 57588 RVA: 0x0006DAAF File Offset: 0x0006BCAF
				public unsafe static int RaymarchingQualitiesStepsMin
				{
					get
					{
						int result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Config.HD.NativeFieldInfoPtr_RaymarchingQualitiesStepsMin, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Config.HD.NativeFieldInfoPtr_RaymarchingQualitiesStepsMin, (void*)(&value));
					}
				}

				// Token: 0x04009687 RID: 38535
				private static readonly IntPtr NativeFieldInfoPtr_GeometryRenderQueueDefault;

				// Token: 0x04009688 RID: 38536
				private static readonly IntPtr NativeFieldInfoPtr_CameraBlendingDistance;

				// Token: 0x04009689 RID: 38537
				private static readonly IntPtr NativeFieldInfoPtr_RaymarchingQualitiesStepsMin;
			}
		}
	}
}
