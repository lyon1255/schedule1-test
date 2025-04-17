﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000063 RID: 99
	[Serializable]
	public class ChromaticAberrationModel : PostProcessingModel
	{
		// Token: 0x06000754 RID: 1876 RVA: 0x00086A78 File Offset: 0x00084C78
		// Note: this type is marked as 'beforefieldinit'.
		static ChromaticAberrationModel()
		{
			Il2CppClassPointerStore<ChromaticAberrationModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "ChromaticAberrationModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChromaticAberrationModel>.NativeClassPtr);
			ChromaticAberrationModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChromaticAberrationModel>.NativeClassPtr, "m_Settings");
			ChromaticAberrationModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChromaticAberrationModel>.NativeClassPtr, 100664069);
			ChromaticAberrationModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChromaticAberrationModel>.NativeClassPtr, 100664070);
			ChromaticAberrationModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChromaticAberrationModel>.NativeClassPtr, 100664071);
			ChromaticAberrationModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChromaticAberrationModel>.NativeClassPtr, 100664072);
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x00086B0C File Offset: 0x00084D0C
		// (set) Token: 0x06000756 RID: 1878 RVA: 0x00086B44 File Offset: 0x00084D44
		public unsafe ChromaticAberrationModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ChromaticAberrationModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ChromaticAberrationModel.Settings(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77768, XrefRangeEnd = 77769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChromaticAberrationModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00086B8C File Offset: 0x00084D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77769, XrefRangeEnd = 77771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChromaticAberrationModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00086BC8 File Offset: 0x00084DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77771, XrefRangeEnd = 77774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChromaticAberrationModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChromaticAberrationModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChromaticAberrationModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00006064 File Offset: 0x00004264
		public ChromaticAberrationModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x00086C04 File Offset: 0x00084E04
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x0000606D File Offset: 0x0000426D
		public ChromaticAberrationModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChromaticAberrationModel.NativeFieldInfoPtr_m_Settings);
				return new ChromaticAberrationModel.Settings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChromaticAberrationModel.Settings>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChromaticAberrationModel.NativeFieldInfoPtr_m_Settings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ChromaticAberrationModel.Settings>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007EA RID: 2026
		[Serializable]
		public sealed class Settings : ValueType
		{
			// Token: 0x0600BC71 RID: 48241 RVA: 0x002E776C File Offset: 0x002E596C
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<ChromaticAberrationModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChromaticAberrationModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChromaticAberrationModel.Settings>.NativeClassPtr);
				ChromaticAberrationModel.Settings.NativeFieldInfoPtr_spectralTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChromaticAberrationModel.Settings>.NativeClassPtr, "spectralTexture");
				ChromaticAberrationModel.Settings.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChromaticAberrationModel.Settings>.NativeClassPtr, "intensity");
				ChromaticAberrationModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChromaticAberrationModel.Settings>.NativeClassPtr, 100664073);
			}

			// Token: 0x17003A66 RID: 14950
			// (get) Token: 0x0600BC72 RID: 48242 RVA: 0x002E77D4 File Offset: 0x002E59D4
			public unsafe static ChromaticAberrationModel.Settings defaultSettings
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77767, XrefRangeEnd = 77768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ChromaticAberrationModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new ChromaticAberrationModel.Settings(pointer);
				}
			}

			// Token: 0x0600BC73 RID: 48243 RVA: 0x0005C248 File Offset: 0x0005A448
			public Settings(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BC74 RID: 48244 RVA: 0x0005C251 File Offset: 0x0005A451
			public Settings() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChromaticAberrationModel.Settings>.NativeClassPtr))
			{
			}

			// Token: 0x17003A64 RID: 14948
			// (get) Token: 0x0600BC75 RID: 48245 RVA: 0x002E7800 File Offset: 0x002E5A00
			// (set) Token: 0x0600BC76 RID: 48246 RVA: 0x0005C263 File Offset: 0x0005A463
			public unsafe Texture2D spectralTexture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChromaticAberrationModel.Settings.NativeFieldInfoPtr_spectralTexture);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChromaticAberrationModel.Settings.NativeFieldInfoPtr_spectralTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A65 RID: 14949
			// (get) Token: 0x0600BC77 RID: 48247 RVA: 0x002E7830 File Offset: 0x002E5A30
			// (set) Token: 0x0600BC78 RID: 48248 RVA: 0x0005C282 File Offset: 0x0005A482
			public unsafe float intensity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChromaticAberrationModel.Settings.NativeFieldInfoPtr_intensity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChromaticAberrationModel.Settings.NativeFieldInfoPtr_intensity)) = value;
				}
			}

			// Token: 0x04007F3B RID: 32571
			private static readonly IntPtr NativeFieldInfoPtr_spectralTexture;

			// Token: 0x04007F3C RID: 32572
			private static readonly IntPtr NativeFieldInfoPtr_intensity;

			// Token: 0x04007F3D RID: 32573
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;
		}
	}
}
