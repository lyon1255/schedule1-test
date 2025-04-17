using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200006D RID: 109
	[Serializable]
	public class VignetteModel : PostProcessingModel
	{
		// Token: 0x060007AD RID: 1965 RVA: 0x00087D9C File Offset: 0x00085F9C
		// Note: this type is marked as 'beforefieldinit'.
		static VignetteModel()
		{
			Il2CppClassPointerStore<VignetteModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "VignetteModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VignetteModel>.NativeClassPtr);
			VignetteModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteModel>.NativeClassPtr, "m_Settings");
			VignetteModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VignetteModel>.NativeClassPtr, 100664131);
			VignetteModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VignetteModel>.NativeClassPtr, 100664132);
			VignetteModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VignetteModel>.NativeClassPtr, 100664133);
			VignetteModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VignetteModel>.NativeClassPtr, 100664134);
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x00087E30 File Offset: 0x00086030
		// (set) Token: 0x060007AF RID: 1967 RVA: 0x00087E68 File Offset: 0x00086068
		public unsafe VignetteModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(VignetteModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new VignetteModel.Settings(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77892, XrefRangeEnd = 77911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VignetteModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00087EB0 File Offset: 0x000860B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77911, XrefRangeEnd = 77913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VignetteModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00087EEC File Offset: 0x000860EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77913, XrefRangeEnd = 77916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VignetteModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VignetteModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VignetteModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x0000623F File Offset: 0x0000443F
		public VignetteModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x00087F28 File Offset: 0x00086128
		// (set) Token: 0x060007B4 RID: 1972 RVA: 0x00006248 File Offset: 0x00004448
		public VignetteModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.NativeFieldInfoPtr_m_Settings);
				return new VignetteModel.Settings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.NativeFieldInfoPtr_m_Settings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000804 RID: 2052
		[OriginalName("Assembly-CSharp.dll", "", "Mode")]
		public enum Mode
		{
			// Token: 0x04007FFC RID: 32764
			Classic,
			// Token: 0x04007FFD RID: 32765
			Masked
		}

		// Token: 0x02000805 RID: 2053
		[Serializable]
		public sealed class Settings : ValueType
		{
			// Token: 0x0600BCDA RID: 48346 RVA: 0x002E8978 File Offset: 0x002E6B78
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VignetteModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr);
				VignetteModel.Settings.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr, "mode");
				VignetteModel.Settings.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr, "color");
				VignetteModel.Settings.NativeFieldInfoPtr_center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr, "center");
				VignetteModel.Settings.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr, "intensity");
				VignetteModel.Settings.NativeFieldInfoPtr_smoothness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr, "smoothness");
				VignetteModel.Settings.NativeFieldInfoPtr_roundness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr, "roundness");
				VignetteModel.Settings.NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr, "mask");
				VignetteModel.Settings.NativeFieldInfoPtr_opacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr, "opacity");
				VignetteModel.Settings.NativeFieldInfoPtr_rounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr, "rounded");
				VignetteModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr, 100664135);
			}

			// Token: 0x17003A94 RID: 14996
			// (get) Token: 0x0600BCDB RID: 48347 RVA: 0x002E8A6C File Offset: 0x002E6C6C
			public unsafe static VignetteModel.Settings defaultSettings
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77891, XrefRangeEnd = 77892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(VignetteModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new VignetteModel.Settings(pointer);
				}
			}

			// Token: 0x0600BCDC RID: 48348 RVA: 0x0005C6C9 File Offset: 0x0005A8C9
			public Settings(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BCDD RID: 48349 RVA: 0x0005C6D2 File Offset: 0x0005A8D2
			public Settings() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VignetteModel.Settings>.NativeClassPtr))
			{
			}

			// Token: 0x17003A8B RID: 14987
			// (get) Token: 0x0600BCDE RID: 48350 RVA: 0x002E8A98 File Offset: 0x002E6C98
			// (set) Token: 0x0600BCDF RID: 48351 RVA: 0x0005C6E4 File Offset: 0x0005A8E4
			public unsafe VignetteModel.Mode mode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_mode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_mode)) = value;
				}
			}

			// Token: 0x17003A8C RID: 14988
			// (get) Token: 0x0600BCE0 RID: 48352 RVA: 0x002E8AC0 File Offset: 0x002E6CC0
			// (set) Token: 0x0600BCE1 RID: 48353 RVA: 0x0005C6FF File Offset: 0x0005A8FF
			public unsafe Color color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x17003A8D RID: 14989
			// (get) Token: 0x0600BCE2 RID: 48354 RVA: 0x002E8AE8 File Offset: 0x002E6CE8
			// (set) Token: 0x0600BCE3 RID: 48355 RVA: 0x0005C71A File Offset: 0x0005A91A
			public unsafe Vector2 center
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_center);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_center)) = value;
				}
			}

			// Token: 0x17003A8E RID: 14990
			// (get) Token: 0x0600BCE4 RID: 48356 RVA: 0x002E8B10 File Offset: 0x002E6D10
			// (set) Token: 0x0600BCE5 RID: 48357 RVA: 0x0005C735 File Offset: 0x0005A935
			public unsafe float intensity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_intensity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_intensity)) = value;
				}
			}

			// Token: 0x17003A8F RID: 14991
			// (get) Token: 0x0600BCE6 RID: 48358 RVA: 0x002E8B38 File Offset: 0x002E6D38
			// (set) Token: 0x0600BCE7 RID: 48359 RVA: 0x0005C750 File Offset: 0x0005A950
			public unsafe float smoothness
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_smoothness);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_smoothness)) = value;
				}
			}

			// Token: 0x17003A90 RID: 14992
			// (get) Token: 0x0600BCE8 RID: 48360 RVA: 0x002E8B60 File Offset: 0x002E6D60
			// (set) Token: 0x0600BCE9 RID: 48361 RVA: 0x0005C76B File Offset: 0x0005A96B
			public unsafe float roundness
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_roundness);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_roundness)) = value;
				}
			}

			// Token: 0x17003A91 RID: 14993
			// (get) Token: 0x0600BCEA RID: 48362 RVA: 0x002E8B88 File Offset: 0x002E6D88
			// (set) Token: 0x0600BCEB RID: 48363 RVA: 0x0005C786 File Offset: 0x0005A986
			public unsafe Texture mask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_mask);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_mask), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A92 RID: 14994
			// (get) Token: 0x0600BCEC RID: 48364 RVA: 0x002E8BB8 File Offset: 0x002E6DB8
			// (set) Token: 0x0600BCED RID: 48365 RVA: 0x0005C7A5 File Offset: 0x0005A9A5
			public unsafe float opacity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_opacity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_opacity)) = value;
				}
			}

			// Token: 0x17003A93 RID: 14995
			// (get) Token: 0x0600BCEE RID: 48366 RVA: 0x002E8BE0 File Offset: 0x002E6DE0
			// (set) Token: 0x0600BCEF RID: 48367 RVA: 0x0005C7C0 File Offset: 0x0005A9C0
			public unsafe bool rounded
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_rounded);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VignetteModel.Settings.NativeFieldInfoPtr_rounded)) = value;
				}
			}

			// Token: 0x04007FFE RID: 32766
			private static readonly IntPtr NativeFieldInfoPtr_mode;

			// Token: 0x04007FFF RID: 32767
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04008000 RID: 32768
			private static readonly IntPtr NativeFieldInfoPtr_center;

			// Token: 0x04008001 RID: 32769
			private static readonly IntPtr NativeFieldInfoPtr_intensity;

			// Token: 0x04008002 RID: 32770
			private static readonly IntPtr NativeFieldInfoPtr_smoothness;

			// Token: 0x04008003 RID: 32771
			private static readonly IntPtr NativeFieldInfoPtr_roundness;

			// Token: 0x04008004 RID: 32772
			private static readonly IntPtr NativeFieldInfoPtr_mask;

			// Token: 0x04008005 RID: 32773
			private static readonly IntPtr NativeFieldInfoPtr_opacity;

			// Token: 0x04008006 RID: 32774
			private static readonly IntPtr NativeFieldInfoPtr_rounded;

			// Token: 0x04008007 RID: 32775
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;
		}
	}
}
