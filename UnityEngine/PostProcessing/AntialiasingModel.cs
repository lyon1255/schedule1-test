using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000060 RID: 96
	[Serializable]
	public class AntialiasingModel : PostProcessingModel
	{
		// Token: 0x0600073A RID: 1850 RVA: 0x000864AC File Offset: 0x000846AC
		// Note: this type is marked as 'beforefieldinit'.
		static AntialiasingModel()
		{
			Il2CppClassPointerStore<AntialiasingModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "AntialiasingModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AntialiasingModel>.NativeClassPtr);
			AntialiasingModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel>.NativeClassPtr, "m_Settings");
			AntialiasingModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntialiasingModel>.NativeClassPtr, 100664042);
			AntialiasingModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntialiasingModel>.NativeClassPtr, 100664043);
			AntialiasingModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntialiasingModel>.NativeClassPtr, 100664044);
			AntialiasingModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntialiasingModel>.NativeClassPtr, 100664045);
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x00086540 File Offset: 0x00084740
		// (set) Token: 0x0600073C RID: 1852 RVA: 0x0008657C File Offset: 0x0008477C
		public unsafe AntialiasingModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AntialiasingModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AntialiasingModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x000865BC File Offset: 0x000847BC
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AntialiasingModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x000865F8 File Offset: 0x000847F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77743, XrefRangeEnd = 77744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AntialiasingModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AntialiasingModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AntialiasingModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00005FE5 File Offset: 0x000041E5
		public AntialiasingModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x00086634 File Offset: 0x00084834
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x00005FEE File Offset: 0x000041EE
		public unsafe AntialiasingModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AntialiasingModel.NativeFieldInfoPtr_m_Settings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AntialiasingModel.NativeFieldInfoPtr_m_Settings)) = value;
			}
		}

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007DC RID: 2012
		[OriginalName("Assembly-CSharp.dll", "", "Method")]
		public enum Method
		{
			// Token: 0x04007EDB RID: 32475
			Fxaa,
			// Token: 0x04007EDC RID: 32476
			Taa
		}

		// Token: 0x020007DD RID: 2013
		[OriginalName("Assembly-CSharp.dll", "", "FxaaPreset")]
		public enum FxaaPreset
		{
			// Token: 0x04007EDE RID: 32478
			ExtremePerformance,
			// Token: 0x04007EDF RID: 32479
			Performance,
			// Token: 0x04007EE0 RID: 32480
			Default,
			// Token: 0x04007EE1 RID: 32481
			Quality,
			// Token: 0x04007EE2 RID: 32482
			ExtremeQuality
		}

		// Token: 0x020007DE RID: 2014
		[Serializable]
		[StructLayout(2)]
		public struct FxaaQualitySettings
		{
			// Token: 0x0600BC42 RID: 48194 RVA: 0x002E6ED0 File Offset: 0x002E50D0
			// Note: this type is marked as 'beforefieldinit'.
			static FxaaQualitySettings()
			{
				Il2CppClassPointerStore<AntialiasingModel.FxaaQualitySettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AntialiasingModel>.NativeClassPtr, "FxaaQualitySettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AntialiasingModel.FxaaQualitySettings>.NativeClassPtr);
				AntialiasingModel.FxaaQualitySettings.NativeFieldInfoPtr_subpixelAliasingRemovalAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.FxaaQualitySettings>.NativeClassPtr, "subpixelAliasingRemovalAmount");
				AntialiasingModel.FxaaQualitySettings.NativeFieldInfoPtr_edgeDetectionThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.FxaaQualitySettings>.NativeClassPtr, "edgeDetectionThreshold");
				AntialiasingModel.FxaaQualitySettings.NativeFieldInfoPtr_minimumRequiredLuminance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.FxaaQualitySettings>.NativeClassPtr, "minimumRequiredLuminance");
				AntialiasingModel.FxaaQualitySettings.NativeFieldInfoPtr_presets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.FxaaQualitySettings>.NativeClassPtr, "presets");
			}

			// Token: 0x0600BC43 RID: 48195 RVA: 0x0005C0C9 File Offset: 0x0005A2C9
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AntialiasingModel.FxaaQualitySettings>.NativeClassPtr, ref this));
			}

			// Token: 0x17003A54 RID: 14932
			// (get) Token: 0x0600BC44 RID: 48196 RVA: 0x002E6F4C File Offset: 0x002E514C
			// (set) Token: 0x0600BC45 RID: 48197 RVA: 0x0005C0DB File Offset: 0x0005A2DB
			public unsafe static Il2CppStructArray<AntialiasingModel.FxaaQualitySettings> presets
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AntialiasingModel.FxaaQualitySettings.NativeFieldInfoPtr_presets, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AntialiasingModel.FxaaQualitySettings>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AntialiasingModel.FxaaQualitySettings.NativeFieldInfoPtr_presets, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007EE3 RID: 32483
			private static readonly IntPtr NativeFieldInfoPtr_subpixelAliasingRemovalAmount;

			// Token: 0x04007EE4 RID: 32484
			private static readonly IntPtr NativeFieldInfoPtr_edgeDetectionThreshold;

			// Token: 0x04007EE5 RID: 32485
			private static readonly IntPtr NativeFieldInfoPtr_minimumRequiredLuminance;

			// Token: 0x04007EE6 RID: 32486
			private static readonly IntPtr NativeFieldInfoPtr_presets;

			// Token: 0x04007EE7 RID: 32487
			[FieldOffset(0)]
			public float subpixelAliasingRemovalAmount;

			// Token: 0x04007EE8 RID: 32488
			[FieldOffset(4)]
			public float edgeDetectionThreshold;

			// Token: 0x04007EE9 RID: 32489
			[FieldOffset(8)]
			public float minimumRequiredLuminance;
		}

		// Token: 0x020007DF RID: 2015
		[Serializable]
		[StructLayout(2)]
		public struct FxaaConsoleSettings
		{
			// Token: 0x0600BC46 RID: 48198 RVA: 0x002E6F74 File Offset: 0x002E5174
			// Note: this type is marked as 'beforefieldinit'.
			static FxaaConsoleSettings()
			{
				Il2CppClassPointerStore<AntialiasingModel.FxaaConsoleSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AntialiasingModel>.NativeClassPtr, "FxaaConsoleSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AntialiasingModel.FxaaConsoleSettings>.NativeClassPtr);
				AntialiasingModel.FxaaConsoleSettings.NativeFieldInfoPtr_subpixelSpreadAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.FxaaConsoleSettings>.NativeClassPtr, "subpixelSpreadAmount");
				AntialiasingModel.FxaaConsoleSettings.NativeFieldInfoPtr_edgeSharpnessAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.FxaaConsoleSettings>.NativeClassPtr, "edgeSharpnessAmount");
				AntialiasingModel.FxaaConsoleSettings.NativeFieldInfoPtr_edgeDetectionThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.FxaaConsoleSettings>.NativeClassPtr, "edgeDetectionThreshold");
				AntialiasingModel.FxaaConsoleSettings.NativeFieldInfoPtr_minimumRequiredLuminance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.FxaaConsoleSettings>.NativeClassPtr, "minimumRequiredLuminance");
				AntialiasingModel.FxaaConsoleSettings.NativeFieldInfoPtr_presets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.FxaaConsoleSettings>.NativeClassPtr, "presets");
			}

			// Token: 0x0600BC47 RID: 48199 RVA: 0x0005C0ED File Offset: 0x0005A2ED
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AntialiasingModel.FxaaConsoleSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x17003A55 RID: 14933
			// (get) Token: 0x0600BC48 RID: 48200 RVA: 0x002E7004 File Offset: 0x002E5204
			// (set) Token: 0x0600BC49 RID: 48201 RVA: 0x0005C0FF File Offset: 0x0005A2FF
			public unsafe static Il2CppStructArray<AntialiasingModel.FxaaConsoleSettings> presets
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AntialiasingModel.FxaaConsoleSettings.NativeFieldInfoPtr_presets, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AntialiasingModel.FxaaConsoleSettings>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AntialiasingModel.FxaaConsoleSettings.NativeFieldInfoPtr_presets, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007EEA RID: 32490
			private static readonly IntPtr NativeFieldInfoPtr_subpixelSpreadAmount;

			// Token: 0x04007EEB RID: 32491
			private static readonly IntPtr NativeFieldInfoPtr_edgeSharpnessAmount;

			// Token: 0x04007EEC RID: 32492
			private static readonly IntPtr NativeFieldInfoPtr_edgeDetectionThreshold;

			// Token: 0x04007EED RID: 32493
			private static readonly IntPtr NativeFieldInfoPtr_minimumRequiredLuminance;

			// Token: 0x04007EEE RID: 32494
			private static readonly IntPtr NativeFieldInfoPtr_presets;

			// Token: 0x04007EEF RID: 32495
			[FieldOffset(0)]
			public float subpixelSpreadAmount;

			// Token: 0x04007EF0 RID: 32496
			[FieldOffset(4)]
			public float edgeSharpnessAmount;

			// Token: 0x04007EF1 RID: 32497
			[FieldOffset(8)]
			public float edgeDetectionThreshold;

			// Token: 0x04007EF2 RID: 32498
			[FieldOffset(12)]
			public float minimumRequiredLuminance;
		}

		// Token: 0x020007E0 RID: 2016
		[Serializable]
		[StructLayout(2)]
		public struct FxaaSettings
		{
			// Token: 0x0600BC4A RID: 48202 RVA: 0x002E702C File Offset: 0x002E522C
			// Note: this type is marked as 'beforefieldinit'.
			static FxaaSettings()
			{
				Il2CppClassPointerStore<AntialiasingModel.FxaaSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AntialiasingModel>.NativeClassPtr, "FxaaSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AntialiasingModel.FxaaSettings>.NativeClassPtr);
				AntialiasingModel.FxaaSettings.NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.FxaaSettings>.NativeClassPtr, "preset");
				AntialiasingModel.FxaaSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_FxaaSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntialiasingModel.FxaaSettings>.NativeClassPtr, 100664048);
			}

			// Token: 0x17003A56 RID: 14934
			// (get) Token: 0x0600BC4B RID: 48203 RVA: 0x002E7080 File Offset: 0x002E5280
			public unsafe static AntialiasingModel.FxaaSettings defaultSettings
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 77736, RefRangeEnd = 77743, XrefRangeStart = 77736, XrefRangeEnd = 77736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AntialiasingModel.FxaaSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_FxaaSettings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC4C RID: 48204 RVA: 0x0005C111 File Offset: 0x0005A311
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AntialiasingModel.FxaaSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007EF3 RID: 32499
			private static readonly IntPtr NativeFieldInfoPtr_preset;

			// Token: 0x04007EF4 RID: 32500
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_FxaaSettings_0;

			// Token: 0x04007EF5 RID: 32501
			[FieldOffset(0)]
			public AntialiasingModel.FxaaPreset preset;
		}

		// Token: 0x020007E1 RID: 2017
		[Serializable]
		[StructLayout(2)]
		public struct TaaSettings
		{
			// Token: 0x0600BC4D RID: 48205 RVA: 0x002E70B0 File Offset: 0x002E52B0
			// Note: this type is marked as 'beforefieldinit'.
			static TaaSettings()
			{
				Il2CppClassPointerStore<AntialiasingModel.TaaSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AntialiasingModel>.NativeClassPtr, "TaaSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AntialiasingModel.TaaSettings>.NativeClassPtr);
				AntialiasingModel.TaaSettings.NativeFieldInfoPtr_jitterSpread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.TaaSettings>.NativeClassPtr, "jitterSpread");
				AntialiasingModel.TaaSettings.NativeFieldInfoPtr_sharpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.TaaSettings>.NativeClassPtr, "sharpen");
				AntialiasingModel.TaaSettings.NativeFieldInfoPtr_stationaryBlending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.TaaSettings>.NativeClassPtr, "stationaryBlending");
				AntialiasingModel.TaaSettings.NativeFieldInfoPtr_motionBlending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.TaaSettings>.NativeClassPtr, "motionBlending");
				AntialiasingModel.TaaSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_TaaSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntialiasingModel.TaaSettings>.NativeClassPtr, 100664049);
			}

			// Token: 0x17003A57 RID: 14935
			// (get) Token: 0x0600BC4E RID: 48206 RVA: 0x002E7140 File Offset: 0x002E5340
			public unsafe static AntialiasingModel.TaaSettings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AntialiasingModel.TaaSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_TaaSettings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC4F RID: 48207 RVA: 0x0005C123 File Offset: 0x0005A323
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AntialiasingModel.TaaSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007EF6 RID: 32502
			private static readonly IntPtr NativeFieldInfoPtr_jitterSpread;

			// Token: 0x04007EF7 RID: 32503
			private static readonly IntPtr NativeFieldInfoPtr_sharpen;

			// Token: 0x04007EF8 RID: 32504
			private static readonly IntPtr NativeFieldInfoPtr_stationaryBlending;

			// Token: 0x04007EF9 RID: 32505
			private static readonly IntPtr NativeFieldInfoPtr_motionBlending;

			// Token: 0x04007EFA RID: 32506
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_TaaSettings_0;

			// Token: 0x04007EFB RID: 32507
			[FieldOffset(0)]
			public float jitterSpread;

			// Token: 0x04007EFC RID: 32508
			[FieldOffset(4)]
			public float sharpen;

			// Token: 0x04007EFD RID: 32509
			[FieldOffset(8)]
			public float stationaryBlending;

			// Token: 0x04007EFE RID: 32510
			[FieldOffset(12)]
			public float motionBlending;
		}

		// Token: 0x020007E2 RID: 2018
		[Serializable]
		[StructLayout(2)]
		public struct Settings
		{
			// Token: 0x0600BC50 RID: 48208 RVA: 0x002E7170 File Offset: 0x002E5370
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<AntialiasingModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AntialiasingModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AntialiasingModel.Settings>.NativeClassPtr);
				AntialiasingModel.Settings.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.Settings>.NativeClassPtr, "method");
				AntialiasingModel.Settings.NativeFieldInfoPtr_fxaaSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.Settings>.NativeClassPtr, "fxaaSettings");
				AntialiasingModel.Settings.NativeFieldInfoPtr_taaSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntialiasingModel.Settings>.NativeClassPtr, "taaSettings");
				AntialiasingModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntialiasingModel.Settings>.NativeClassPtr, 100664050);
			}

			// Token: 0x17003A58 RID: 14936
			// (get) Token: 0x0600BC51 RID: 48209 RVA: 0x002E71EC File Offset: 0x002E53EC
			public unsafe static AntialiasingModel.Settings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AntialiasingModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC52 RID: 48210 RVA: 0x0005C135 File Offset: 0x0005A335
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AntialiasingModel.Settings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007EFF RID: 32511
			private static readonly IntPtr NativeFieldInfoPtr_method;

			// Token: 0x04007F00 RID: 32512
			private static readonly IntPtr NativeFieldInfoPtr_fxaaSettings;

			// Token: 0x04007F01 RID: 32513
			private static readonly IntPtr NativeFieldInfoPtr_taaSettings;

			// Token: 0x04007F02 RID: 32514
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;

			// Token: 0x04007F03 RID: 32515
			[FieldOffset(0)]
			public AntialiasingModel.Method method;

			// Token: 0x04007F04 RID: 32516
			[FieldOffset(4)]
			public AntialiasingModel.FxaaSettings fxaaSettings;

			// Token: 0x04007F05 RID: 32517
			[FieldOffset(8)]
			public AntialiasingModel.TaaSettings taaSettings;
		}
	}
}
