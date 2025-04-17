using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000064 RID: 100
	[Serializable]
	public class ColorGradingModel : PostProcessingModel
	{
		// Token: 0x0600075C RID: 1884 RVA: 0x00086C34 File Offset: 0x00084E34
		// Note: this type is marked as 'beforefieldinit'.
		static ColorGradingModel()
		{
			Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "ColorGradingModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr);
			ColorGradingModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, "m_Settings");
			ColorGradingModel.NativeFieldInfoPtr__isDirty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, "<isDirty>k__BackingField");
			ColorGradingModel.NativeFieldInfoPtr__bakedLut_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, "<bakedLut>k__BackingField");
			ColorGradingModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, 100664074);
			ColorGradingModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, 100664075);
			ColorGradingModel.NativeMethodInfoPtr_get_isDirty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, 100664076);
			ColorGradingModel.NativeMethodInfoPtr_set_isDirty_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, 100664077);
			ColorGradingModel.NativeMethodInfoPtr_get_bakedLut_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, 100664078);
			ColorGradingModel.NativeMethodInfoPtr_set_bakedLut_Internal_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, 100664079);
			ColorGradingModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, 100664080);
			ColorGradingModel.NativeMethodInfoPtr_OnValidate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, 100664081);
			ColorGradingModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, 100664082);
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x00086D54 File Offset: 0x00084F54
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x00086D8C File Offset: 0x00084F8C
		public unsafe ColorGradingModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ColorGradingModel.Settings(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77871, XrefRangeEnd = 77872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x00086DD4 File Offset: 0x00084FD4
		// (set) Token: 0x06000760 RID: 1888 RVA: 0x00086E10 File Offset: 0x00085010
		public unsafe bool isDirty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.NativeMethodInfoPtr_get_isDirty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.NativeMethodInfoPtr_set_isDirty_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x00086E50 File Offset: 0x00085050
		// (set) Token: 0x06000762 RID: 1890 RVA: 0x00086E90 File Offset: 0x00085090
		public unsafe RenderTexture bakedLut
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.NativeMethodInfoPtr_get_bakedLut_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77872, XrefRangeEnd = 77873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.NativeMethodInfoPtr_set_bakedLut_Internal_set_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00086ED4 File Offset: 0x000850D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77873, XrefRangeEnd = 77875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorGradingModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00086F10 File Offset: 0x00085110
		[CallerCount(0)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorGradingModel.NativeMethodInfoPtr_OnValidate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00086F4C File Offset: 0x0008514C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77875, XrefRangeEnd = 77878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorGradingModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x0000609B File Offset: 0x0000429B
		public ColorGradingModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x00086F88 File Offset: 0x00085188
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x000060A4 File Offset: 0x000042A4
		public ColorGradingModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.NativeFieldInfoPtr_m_Settings);
				return new ColorGradingModel.Settings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ColorGradingModel.Settings>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.NativeFieldInfoPtr_m_Settings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ColorGradingModel.Settings>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x00086FB8 File Offset: 0x000851B8
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x000060D2 File Offset: 0x000042D2
		public unsafe bool _isDirty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.NativeFieldInfoPtr__isDirty_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.NativeFieldInfoPtr__isDirty_k__BackingField)) = value;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x00086FE0 File Offset: 0x000851E0
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x000060ED File Offset: 0x000042ED
		public unsafe RenderTexture _bakedLut_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.NativeFieldInfoPtr__bakedLut_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.NativeFieldInfoPtr__bakedLut_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeFieldInfoPtr__isDirty_k__BackingField;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeFieldInfoPtr__bakedLut_k__BackingField;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeMethodInfoPtr_get_isDirty_Public_get_Boolean_0;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeMethodInfoPtr_set_isDirty_Internal_set_Void_Boolean_0;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeMethodInfoPtr_get_bakedLut_Public_get_RenderTexture_0;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeMethodInfoPtr_set_bakedLut_Internal_set_Void_RenderTexture_0;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Public_Virtual_Void_0;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007EB RID: 2027
		[OriginalName("Assembly-CSharp.dll", "", "Tonemapper")]
		public enum Tonemapper
		{
			// Token: 0x04007F3F RID: 32575
			None,
			// Token: 0x04007F40 RID: 32576
			ACES,
			// Token: 0x04007F41 RID: 32577
			Neutral
		}

		// Token: 0x020007EC RID: 2028
		[Serializable]
		[StructLayout(2)]
		public struct TonemappingSettings
		{
			// Token: 0x0600BC79 RID: 48249 RVA: 0x002E7858 File Offset: 0x002E5A58
			// Note: this type is marked as 'beforefieldinit'.
			static TonemappingSettings()
			{
				Il2CppClassPointerStore<ColorGradingModel.TonemappingSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, "TonemappingSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingModel.TonemappingSettings>.NativeClassPtr);
				ColorGradingModel.TonemappingSettings.NativeFieldInfoPtr_tonemapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.TonemappingSettings>.NativeClassPtr, "tonemapper");
				ColorGradingModel.TonemappingSettings.NativeFieldInfoPtr_neutralBlackIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.TonemappingSettings>.NativeClassPtr, "neutralBlackIn");
				ColorGradingModel.TonemappingSettings.NativeFieldInfoPtr_neutralWhiteIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.TonemappingSettings>.NativeClassPtr, "neutralWhiteIn");
				ColorGradingModel.TonemappingSettings.NativeFieldInfoPtr_neutralBlackOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.TonemappingSettings>.NativeClassPtr, "neutralBlackOut");
				ColorGradingModel.TonemappingSettings.NativeFieldInfoPtr_neutralWhiteOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.TonemappingSettings>.NativeClassPtr, "neutralWhiteOut");
				ColorGradingModel.TonemappingSettings.NativeFieldInfoPtr_neutralWhiteLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.TonemappingSettings>.NativeClassPtr, "neutralWhiteLevel");
				ColorGradingModel.TonemappingSettings.NativeFieldInfoPtr_neutralWhiteClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.TonemappingSettings>.NativeClassPtr, "neutralWhiteClip");
				ColorGradingModel.TonemappingSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_TonemappingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel.TonemappingSettings>.NativeClassPtr, 100664083);
			}

			// Token: 0x17003A67 RID: 14951
			// (get) Token: 0x0600BC7A RID: 48250 RVA: 0x002E7924 File Offset: 0x002E5B24
			public unsafe static ColorGradingModel.TonemappingSettings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.TonemappingSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_TonemappingSettings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC7B RID: 48251 RVA: 0x0005C29D File Offset: 0x0005A49D
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ColorGradingModel.TonemappingSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007F42 RID: 32578
			private static readonly IntPtr NativeFieldInfoPtr_tonemapper;

			// Token: 0x04007F43 RID: 32579
			private static readonly IntPtr NativeFieldInfoPtr_neutralBlackIn;

			// Token: 0x04007F44 RID: 32580
			private static readonly IntPtr NativeFieldInfoPtr_neutralWhiteIn;

			// Token: 0x04007F45 RID: 32581
			private static readonly IntPtr NativeFieldInfoPtr_neutralBlackOut;

			// Token: 0x04007F46 RID: 32582
			private static readonly IntPtr NativeFieldInfoPtr_neutralWhiteOut;

			// Token: 0x04007F47 RID: 32583
			private static readonly IntPtr NativeFieldInfoPtr_neutralWhiteLevel;

			// Token: 0x04007F48 RID: 32584
			private static readonly IntPtr NativeFieldInfoPtr_neutralWhiteClip;

			// Token: 0x04007F49 RID: 32585
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_TonemappingSettings_0;

			// Token: 0x04007F4A RID: 32586
			[FieldOffset(0)]
			public ColorGradingModel.Tonemapper tonemapper;

			// Token: 0x04007F4B RID: 32587
			[FieldOffset(4)]
			public float neutralBlackIn;

			// Token: 0x04007F4C RID: 32588
			[FieldOffset(8)]
			public float neutralWhiteIn;

			// Token: 0x04007F4D RID: 32589
			[FieldOffset(12)]
			public float neutralBlackOut;

			// Token: 0x04007F4E RID: 32590
			[FieldOffset(16)]
			public float neutralWhiteOut;

			// Token: 0x04007F4F RID: 32591
			[FieldOffset(20)]
			public float neutralWhiteLevel;

			// Token: 0x04007F50 RID: 32592
			[FieldOffset(24)]
			public float neutralWhiteClip;
		}

		// Token: 0x020007ED RID: 2029
		[Serializable]
		[StructLayout(2)]
		public struct BasicSettings
		{
			// Token: 0x0600BC7C RID: 48252 RVA: 0x002E7954 File Offset: 0x002E5B54
			// Note: this type is marked as 'beforefieldinit'.
			static BasicSettings()
			{
				Il2CppClassPointerStore<ColorGradingModel.BasicSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, "BasicSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingModel.BasicSettings>.NativeClassPtr);
				ColorGradingModel.BasicSettings.NativeFieldInfoPtr_postExposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.BasicSettings>.NativeClassPtr, "postExposure");
				ColorGradingModel.BasicSettings.NativeFieldInfoPtr_temperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.BasicSettings>.NativeClassPtr, "temperature");
				ColorGradingModel.BasicSettings.NativeFieldInfoPtr_tint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.BasicSettings>.NativeClassPtr, "tint");
				ColorGradingModel.BasicSettings.NativeFieldInfoPtr_hueShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.BasicSettings>.NativeClassPtr, "hueShift");
				ColorGradingModel.BasicSettings.NativeFieldInfoPtr_saturation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.BasicSettings>.NativeClassPtr, "saturation");
				ColorGradingModel.BasicSettings.NativeFieldInfoPtr_contrast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.BasicSettings>.NativeClassPtr, "contrast");
				ColorGradingModel.BasicSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_BasicSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel.BasicSettings>.NativeClassPtr, 100664084);
			}

			// Token: 0x17003A68 RID: 14952
			// (get) Token: 0x0600BC7D RID: 48253 RVA: 0x002E7A0C File Offset: 0x002E5C0C
			public unsafe static ColorGradingModel.BasicSettings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.BasicSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_BasicSettings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC7E RID: 48254 RVA: 0x0005C2AF File Offset: 0x0005A4AF
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ColorGradingModel.BasicSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007F51 RID: 32593
			private static readonly IntPtr NativeFieldInfoPtr_postExposure;

			// Token: 0x04007F52 RID: 32594
			private static readonly IntPtr NativeFieldInfoPtr_temperature;

			// Token: 0x04007F53 RID: 32595
			private static readonly IntPtr NativeFieldInfoPtr_tint;

			// Token: 0x04007F54 RID: 32596
			private static readonly IntPtr NativeFieldInfoPtr_hueShift;

			// Token: 0x04007F55 RID: 32597
			private static readonly IntPtr NativeFieldInfoPtr_saturation;

			// Token: 0x04007F56 RID: 32598
			private static readonly IntPtr NativeFieldInfoPtr_contrast;

			// Token: 0x04007F57 RID: 32599
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_BasicSettings_0;

			// Token: 0x04007F58 RID: 32600
			[FieldOffset(0)]
			public float postExposure;

			// Token: 0x04007F59 RID: 32601
			[FieldOffset(4)]
			public float temperature;

			// Token: 0x04007F5A RID: 32602
			[FieldOffset(8)]
			public float tint;

			// Token: 0x04007F5B RID: 32603
			[FieldOffset(12)]
			public float hueShift;

			// Token: 0x04007F5C RID: 32604
			[FieldOffset(16)]
			public float saturation;

			// Token: 0x04007F5D RID: 32605
			[FieldOffset(20)]
			public float contrast;
		}

		// Token: 0x020007EE RID: 2030
		[Serializable]
		[StructLayout(2)]
		public struct ChannelMixerSettings
		{
			// Token: 0x0600BC7F RID: 48255 RVA: 0x002E7A3C File Offset: 0x002E5C3C
			// Note: this type is marked as 'beforefieldinit'.
			static ChannelMixerSettings()
			{
				Il2CppClassPointerStore<ColorGradingModel.ChannelMixerSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, "ChannelMixerSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingModel.ChannelMixerSettings>.NativeClassPtr);
				ColorGradingModel.ChannelMixerSettings.NativeFieldInfoPtr_red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.ChannelMixerSettings>.NativeClassPtr, "red");
				ColorGradingModel.ChannelMixerSettings.NativeFieldInfoPtr_green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.ChannelMixerSettings>.NativeClassPtr, "green");
				ColorGradingModel.ChannelMixerSettings.NativeFieldInfoPtr_blue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.ChannelMixerSettings>.NativeClassPtr, "blue");
				ColorGradingModel.ChannelMixerSettings.NativeFieldInfoPtr_currentEditingChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.ChannelMixerSettings>.NativeClassPtr, "currentEditingChannel");
				ColorGradingModel.ChannelMixerSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_ChannelMixerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel.ChannelMixerSettings>.NativeClassPtr, 100664085);
			}

			// Token: 0x17003A69 RID: 14953
			// (get) Token: 0x0600BC80 RID: 48256 RVA: 0x002E7ACC File Offset: 0x002E5CCC
			public unsafe static ColorGradingModel.ChannelMixerSettings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.ChannelMixerSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_ChannelMixerSettings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC81 RID: 48257 RVA: 0x0005C2C1 File Offset: 0x0005A4C1
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ColorGradingModel.ChannelMixerSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007F5E RID: 32606
			private static readonly IntPtr NativeFieldInfoPtr_red;

			// Token: 0x04007F5F RID: 32607
			private static readonly IntPtr NativeFieldInfoPtr_green;

			// Token: 0x04007F60 RID: 32608
			private static readonly IntPtr NativeFieldInfoPtr_blue;

			// Token: 0x04007F61 RID: 32609
			private static readonly IntPtr NativeFieldInfoPtr_currentEditingChannel;

			// Token: 0x04007F62 RID: 32610
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_ChannelMixerSettings_0;

			// Token: 0x04007F63 RID: 32611
			[FieldOffset(0)]
			public Vector3 red;

			// Token: 0x04007F64 RID: 32612
			[FieldOffset(12)]
			public Vector3 green;

			// Token: 0x04007F65 RID: 32613
			[FieldOffset(24)]
			public Vector3 blue;

			// Token: 0x04007F66 RID: 32614
			[FieldOffset(36)]
			public int currentEditingChannel;
		}

		// Token: 0x020007EF RID: 2031
		[Serializable]
		[StructLayout(2)]
		public struct LogWheelsSettings
		{
			// Token: 0x0600BC82 RID: 48258 RVA: 0x002E7AFC File Offset: 0x002E5CFC
			// Note: this type is marked as 'beforefieldinit'.
			static LogWheelsSettings()
			{
				Il2CppClassPointerStore<ColorGradingModel.LogWheelsSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, "LogWheelsSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingModel.LogWheelsSettings>.NativeClassPtr);
				ColorGradingModel.LogWheelsSettings.NativeFieldInfoPtr_slope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.LogWheelsSettings>.NativeClassPtr, "slope");
				ColorGradingModel.LogWheelsSettings.NativeFieldInfoPtr_power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.LogWheelsSettings>.NativeClassPtr, "power");
				ColorGradingModel.LogWheelsSettings.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.LogWheelsSettings>.NativeClassPtr, "offset");
				ColorGradingModel.LogWheelsSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_LogWheelsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel.LogWheelsSettings>.NativeClassPtr, 100664086);
			}

			// Token: 0x17003A6A RID: 14954
			// (get) Token: 0x0600BC83 RID: 48259 RVA: 0x002E7B78 File Offset: 0x002E5D78
			public unsafe static ColorGradingModel.LogWheelsSettings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.LogWheelsSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_LogWheelsSettings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC84 RID: 48260 RVA: 0x0005C2D3 File Offset: 0x0005A4D3
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ColorGradingModel.LogWheelsSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007F67 RID: 32615
			private static readonly IntPtr NativeFieldInfoPtr_slope;

			// Token: 0x04007F68 RID: 32616
			private static readonly IntPtr NativeFieldInfoPtr_power;

			// Token: 0x04007F69 RID: 32617
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x04007F6A RID: 32618
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_LogWheelsSettings_0;

			// Token: 0x04007F6B RID: 32619
			[FieldOffset(0)]
			public Color slope;

			// Token: 0x04007F6C RID: 32620
			[FieldOffset(16)]
			public Color power;

			// Token: 0x04007F6D RID: 32621
			[FieldOffset(32)]
			public Color offset;
		}

		// Token: 0x020007F0 RID: 2032
		[Serializable]
		[StructLayout(2)]
		public struct LinearWheelsSettings
		{
			// Token: 0x0600BC85 RID: 48261 RVA: 0x002E7BA8 File Offset: 0x002E5DA8
			// Note: this type is marked as 'beforefieldinit'.
			static LinearWheelsSettings()
			{
				Il2CppClassPointerStore<ColorGradingModel.LinearWheelsSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, "LinearWheelsSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingModel.LinearWheelsSettings>.NativeClassPtr);
				ColorGradingModel.LinearWheelsSettings.NativeFieldInfoPtr_lift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.LinearWheelsSettings>.NativeClassPtr, "lift");
				ColorGradingModel.LinearWheelsSettings.NativeFieldInfoPtr_gamma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.LinearWheelsSettings>.NativeClassPtr, "gamma");
				ColorGradingModel.LinearWheelsSettings.NativeFieldInfoPtr_gain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.LinearWheelsSettings>.NativeClassPtr, "gain");
				ColorGradingModel.LinearWheelsSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_LinearWheelsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel.LinearWheelsSettings>.NativeClassPtr, 100664087);
			}

			// Token: 0x17003A6B RID: 14955
			// (get) Token: 0x0600BC86 RID: 48262 RVA: 0x002E7C24 File Offset: 0x002E5E24
			public unsafe static ColorGradingModel.LinearWheelsSettings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.LinearWheelsSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_LinearWheelsSettings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC87 RID: 48263 RVA: 0x0005C2E5 File Offset: 0x0005A4E5
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ColorGradingModel.LinearWheelsSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007F6E RID: 32622
			private static readonly IntPtr NativeFieldInfoPtr_lift;

			// Token: 0x04007F6F RID: 32623
			private static readonly IntPtr NativeFieldInfoPtr_gamma;

			// Token: 0x04007F70 RID: 32624
			private static readonly IntPtr NativeFieldInfoPtr_gain;

			// Token: 0x04007F71 RID: 32625
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_LinearWheelsSettings_0;

			// Token: 0x04007F72 RID: 32626
			[FieldOffset(0)]
			public Color lift;

			// Token: 0x04007F73 RID: 32627
			[FieldOffset(16)]
			public Color gamma;

			// Token: 0x04007F74 RID: 32628
			[FieldOffset(32)]
			public Color gain;
		}

		// Token: 0x020007F1 RID: 2033
		[OriginalName("Assembly-CSharp.dll", "", "ColorWheelMode")]
		public enum ColorWheelMode
		{
			// Token: 0x04007F76 RID: 32630
			Linear,
			// Token: 0x04007F77 RID: 32631
			Log
		}

		// Token: 0x020007F2 RID: 2034
		[Serializable]
		[StructLayout(2)]
		public struct ColorWheelsSettings
		{
			// Token: 0x0600BC88 RID: 48264 RVA: 0x002E7C54 File Offset: 0x002E5E54
			// Note: this type is marked as 'beforefieldinit'.
			static ColorWheelsSettings()
			{
				Il2CppClassPointerStore<ColorGradingModel.ColorWheelsSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, "ColorWheelsSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingModel.ColorWheelsSettings>.NativeClassPtr);
				ColorGradingModel.ColorWheelsSettings.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.ColorWheelsSettings>.NativeClassPtr, "mode");
				ColorGradingModel.ColorWheelsSettings.NativeFieldInfoPtr_log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.ColorWheelsSettings>.NativeClassPtr, "log");
				ColorGradingModel.ColorWheelsSettings.NativeFieldInfoPtr_linear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.ColorWheelsSettings>.NativeClassPtr, "linear");
				ColorGradingModel.ColorWheelsSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_ColorWheelsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel.ColorWheelsSettings>.NativeClassPtr, 100664088);
			}

			// Token: 0x17003A6C RID: 14956
			// (get) Token: 0x0600BC89 RID: 48265 RVA: 0x002E7CD0 File Offset: 0x002E5ED0
			public unsafe static ColorGradingModel.ColorWheelsSettings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.ColorWheelsSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_ColorWheelsSettings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC8A RID: 48266 RVA: 0x0005C2F7 File Offset: 0x0005A4F7
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ColorGradingModel.ColorWheelsSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007F78 RID: 32632
			private static readonly IntPtr NativeFieldInfoPtr_mode;

			// Token: 0x04007F79 RID: 32633
			private static readonly IntPtr NativeFieldInfoPtr_log;

			// Token: 0x04007F7A RID: 32634
			private static readonly IntPtr NativeFieldInfoPtr_linear;

			// Token: 0x04007F7B RID: 32635
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_ColorWheelsSettings_0;

			// Token: 0x04007F7C RID: 32636
			[FieldOffset(0)]
			public ColorGradingModel.ColorWheelMode mode;

			// Token: 0x04007F7D RID: 32637
			[FieldOffset(4)]
			public ColorGradingModel.LogWheelsSettings log;

			// Token: 0x04007F7E RID: 32638
			[FieldOffset(52)]
			public ColorGradingModel.LinearWheelsSettings linear;
		}

		// Token: 0x020007F3 RID: 2035
		[Serializable]
		public sealed class CurvesSettings : ValueType
		{
			// Token: 0x0600BC8B RID: 48267 RVA: 0x002E7D00 File Offset: 0x002E5F00
			// Note: this type is marked as 'beforefieldinit'.
			static CurvesSettings()
			{
				Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, "CurvesSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr);
				ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, "master");
				ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, "red");
				ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, "green");
				ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_blue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, "blue");
				ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_hueVShue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, "hueVShue");
				ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_hueVSsat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, "hueVSsat");
				ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_satVSsat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, "satVSsat");
				ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_lumVSsat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, "lumVSsat");
				ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurrentEditingCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, "e_CurrentEditingCurve");
				ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurveY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, "e_CurveY");
				ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurveR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, "e_CurveR");
				ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurveG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, "e_CurveG");
				ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurveB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, "e_CurveB");
				ColorGradingModel.CurvesSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_CurvesSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, 100664089);
			}

			// Token: 0x17003A7A RID: 14970
			// (get) Token: 0x0600BC8C RID: 48268 RVA: 0x002E7E44 File Offset: 0x002E6044
			public unsafe static ColorGradingModel.CurvesSettings defaultSettings
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 77865, RefRangeEnd = 77866, XrefRangeStart = 77774, XrefRangeEnd = 77865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.CurvesSettings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_CurvesSettings_0, 0, (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new ColorGradingModel.CurvesSettings(pointer);
				}
			}

			// Token: 0x0600BC8D RID: 48269 RVA: 0x0005C309 File Offset: 0x0005A509
			public CurvesSettings(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BC8E RID: 48270 RVA: 0x0005C312 File Offset: 0x0005A512
			public CurvesSettings() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr))
			{
			}

			// Token: 0x17003A6D RID: 14957
			// (get) Token: 0x0600BC8F RID: 48271 RVA: 0x002E7E70 File Offset: 0x002E6070
			// (set) Token: 0x0600BC90 RID: 48272 RVA: 0x0005C324 File Offset: 0x0005A524
			public unsafe ColorGradingCurve master
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_master);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorGradingCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_master), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A6E RID: 14958
			// (get) Token: 0x0600BC91 RID: 48273 RVA: 0x002E7EA0 File Offset: 0x002E60A0
			// (set) Token: 0x0600BC92 RID: 48274 RVA: 0x0005C343 File Offset: 0x0005A543
			public unsafe ColorGradingCurve red
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_red);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorGradingCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_red), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A6F RID: 14959
			// (get) Token: 0x0600BC93 RID: 48275 RVA: 0x002E7ED0 File Offset: 0x002E60D0
			// (set) Token: 0x0600BC94 RID: 48276 RVA: 0x0005C362 File Offset: 0x0005A562
			public unsafe ColorGradingCurve green
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_green);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorGradingCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_green), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A70 RID: 14960
			// (get) Token: 0x0600BC95 RID: 48277 RVA: 0x002E7F00 File Offset: 0x002E6100
			// (set) Token: 0x0600BC96 RID: 48278 RVA: 0x0005C381 File Offset: 0x0005A581
			public unsafe ColorGradingCurve blue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_blue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorGradingCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_blue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A71 RID: 14961
			// (get) Token: 0x0600BC97 RID: 48279 RVA: 0x002E7F30 File Offset: 0x002E6130
			// (set) Token: 0x0600BC98 RID: 48280 RVA: 0x0005C3A0 File Offset: 0x0005A5A0
			public unsafe ColorGradingCurve hueVShue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_hueVShue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorGradingCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_hueVShue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A72 RID: 14962
			// (get) Token: 0x0600BC99 RID: 48281 RVA: 0x002E7F60 File Offset: 0x002E6160
			// (set) Token: 0x0600BC9A RID: 48282 RVA: 0x0005C3BF File Offset: 0x0005A5BF
			public unsafe ColorGradingCurve hueVSsat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_hueVSsat);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorGradingCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_hueVSsat), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A73 RID: 14963
			// (get) Token: 0x0600BC9B RID: 48283 RVA: 0x002E7F90 File Offset: 0x002E6190
			// (set) Token: 0x0600BC9C RID: 48284 RVA: 0x0005C3DE File Offset: 0x0005A5DE
			public unsafe ColorGradingCurve satVSsat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_satVSsat);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorGradingCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_satVSsat), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A74 RID: 14964
			// (get) Token: 0x0600BC9D RID: 48285 RVA: 0x002E7FC0 File Offset: 0x002E61C0
			// (set) Token: 0x0600BC9E RID: 48286 RVA: 0x0005C3FD File Offset: 0x0005A5FD
			public unsafe ColorGradingCurve lumVSsat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_lumVSsat);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorGradingCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_lumVSsat), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A75 RID: 14965
			// (get) Token: 0x0600BC9F RID: 48287 RVA: 0x002E7FF0 File Offset: 0x002E61F0
			// (set) Token: 0x0600BCA0 RID: 48288 RVA: 0x0005C41C File Offset: 0x0005A61C
			public unsafe int e_CurrentEditingCurve
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurrentEditingCurve);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurrentEditingCurve)) = value;
				}
			}

			// Token: 0x17003A76 RID: 14966
			// (get) Token: 0x0600BCA1 RID: 48289 RVA: 0x002E8018 File Offset: 0x002E6218
			// (set) Token: 0x0600BCA2 RID: 48290 RVA: 0x0005C437 File Offset: 0x0005A637
			public unsafe bool e_CurveY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurveY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurveY)) = value;
				}
			}

			// Token: 0x17003A77 RID: 14967
			// (get) Token: 0x0600BCA3 RID: 48291 RVA: 0x002E8040 File Offset: 0x002E6240
			// (set) Token: 0x0600BCA4 RID: 48292 RVA: 0x0005C452 File Offset: 0x0005A652
			public unsafe bool e_CurveR
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurveR);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurveR)) = value;
				}
			}

			// Token: 0x17003A78 RID: 14968
			// (get) Token: 0x0600BCA5 RID: 48293 RVA: 0x002E8068 File Offset: 0x002E6268
			// (set) Token: 0x0600BCA6 RID: 48294 RVA: 0x0005C46D File Offset: 0x0005A66D
			public unsafe bool e_CurveG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurveG);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurveG)) = value;
				}
			}

			// Token: 0x17003A79 RID: 14969
			// (get) Token: 0x0600BCA7 RID: 48295 RVA: 0x002E8090 File Offset: 0x002E6290
			// (set) Token: 0x0600BCA8 RID: 48296 RVA: 0x0005C488 File Offset: 0x0005A688
			public unsafe bool e_CurveB
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurveB);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.CurvesSettings.NativeFieldInfoPtr_e_CurveB)) = value;
				}
			}

			// Token: 0x04007F7F RID: 32639
			private static readonly IntPtr NativeFieldInfoPtr_master;

			// Token: 0x04007F80 RID: 32640
			private static readonly IntPtr NativeFieldInfoPtr_red;

			// Token: 0x04007F81 RID: 32641
			private static readonly IntPtr NativeFieldInfoPtr_green;

			// Token: 0x04007F82 RID: 32642
			private static readonly IntPtr NativeFieldInfoPtr_blue;

			// Token: 0x04007F83 RID: 32643
			private static readonly IntPtr NativeFieldInfoPtr_hueVShue;

			// Token: 0x04007F84 RID: 32644
			private static readonly IntPtr NativeFieldInfoPtr_hueVSsat;

			// Token: 0x04007F85 RID: 32645
			private static readonly IntPtr NativeFieldInfoPtr_satVSsat;

			// Token: 0x04007F86 RID: 32646
			private static readonly IntPtr NativeFieldInfoPtr_lumVSsat;

			// Token: 0x04007F87 RID: 32647
			private static readonly IntPtr NativeFieldInfoPtr_e_CurrentEditingCurve;

			// Token: 0x04007F88 RID: 32648
			private static readonly IntPtr NativeFieldInfoPtr_e_CurveY;

			// Token: 0x04007F89 RID: 32649
			private static readonly IntPtr NativeFieldInfoPtr_e_CurveR;

			// Token: 0x04007F8A RID: 32650
			private static readonly IntPtr NativeFieldInfoPtr_e_CurveG;

			// Token: 0x04007F8B RID: 32651
			private static readonly IntPtr NativeFieldInfoPtr_e_CurveB;

			// Token: 0x04007F8C RID: 32652
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_CurvesSettings_0;
		}

		// Token: 0x020007F4 RID: 2036
		[Serializable]
		public sealed class Settings : ValueType
		{
			// Token: 0x0600BCA9 RID: 48297 RVA: 0x002E80B8 File Offset: 0x002E62B8
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<ColorGradingModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorGradingModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingModel.Settings>.NativeClassPtr);
				ColorGradingModel.Settings.NativeFieldInfoPtr_tonemapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.Settings>.NativeClassPtr, "tonemapping");
				ColorGradingModel.Settings.NativeFieldInfoPtr_basic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.Settings>.NativeClassPtr, "basic");
				ColorGradingModel.Settings.NativeFieldInfoPtr_channelMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.Settings>.NativeClassPtr, "channelMixer");
				ColorGradingModel.Settings.NativeFieldInfoPtr_colorWheels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.Settings>.NativeClassPtr, "colorWheels");
				ColorGradingModel.Settings.NativeFieldInfoPtr_curves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingModel.Settings>.NativeClassPtr, "curves");
				ColorGradingModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingModel.Settings>.NativeClassPtr, 100664090);
			}

			// Token: 0x17003A80 RID: 14976
			// (get) Token: 0x0600BCAA RID: 48298 RVA: 0x002E815C File Offset: 0x002E635C
			public unsafe static ColorGradingModel.Settings defaultSettings
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 77868, RefRangeEnd = 77871, XrefRangeStart = 77866, XrefRangeEnd = 77868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ColorGradingModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new ColorGradingModel.Settings(pointer);
				}
			}

			// Token: 0x0600BCAB RID: 48299 RVA: 0x0005C4A3 File Offset: 0x0005A6A3
			public Settings(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BCAC RID: 48300 RVA: 0x0005C4AC File Offset: 0x0005A6AC
			public Settings() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorGradingModel.Settings>.NativeClassPtr))
			{
			}

			// Token: 0x17003A7B RID: 14971
			// (get) Token: 0x0600BCAD RID: 48301 RVA: 0x002E8188 File Offset: 0x002E6388
			// (set) Token: 0x0600BCAE RID: 48302 RVA: 0x0005C4BE File Offset: 0x0005A6BE
			public unsafe ColorGradingModel.TonemappingSettings tonemapping
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.Settings.NativeFieldInfoPtr_tonemapping);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.Settings.NativeFieldInfoPtr_tonemapping)) = value;
				}
			}

			// Token: 0x17003A7C RID: 14972
			// (get) Token: 0x0600BCAF RID: 48303 RVA: 0x002E81B0 File Offset: 0x002E63B0
			// (set) Token: 0x0600BCB0 RID: 48304 RVA: 0x0005C4D9 File Offset: 0x0005A6D9
			public unsafe ColorGradingModel.BasicSettings basic
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.Settings.NativeFieldInfoPtr_basic);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.Settings.NativeFieldInfoPtr_basic)) = value;
				}
			}

			// Token: 0x17003A7D RID: 14973
			// (get) Token: 0x0600BCB1 RID: 48305 RVA: 0x002E81D8 File Offset: 0x002E63D8
			// (set) Token: 0x0600BCB2 RID: 48306 RVA: 0x0005C4F4 File Offset: 0x0005A6F4
			public unsafe ColorGradingModel.ChannelMixerSettings channelMixer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.Settings.NativeFieldInfoPtr_channelMixer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.Settings.NativeFieldInfoPtr_channelMixer)) = value;
				}
			}

			// Token: 0x17003A7E RID: 14974
			// (get) Token: 0x0600BCB3 RID: 48307 RVA: 0x002E8200 File Offset: 0x002E6400
			// (set) Token: 0x0600BCB4 RID: 48308 RVA: 0x0005C50F File Offset: 0x0005A70F
			public unsafe ColorGradingModel.ColorWheelsSettings colorWheels
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.Settings.NativeFieldInfoPtr_colorWheels);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.Settings.NativeFieldInfoPtr_colorWheels)) = value;
				}
			}

			// Token: 0x17003A7F RID: 14975
			// (get) Token: 0x0600BCB5 RID: 48309 RVA: 0x002E8228 File Offset: 0x002E6428
			// (set) Token: 0x0600BCB6 RID: 48310 RVA: 0x0005C52A File Offset: 0x0005A72A
			public ColorGradingModel.CurvesSettings curves
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.Settings.NativeFieldInfoPtr_curves);
					return new ColorGradingModel.CurvesSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingModel.Settings.NativeFieldInfoPtr_curves), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ColorGradingModel.CurvesSettings>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04007F8D RID: 32653
			private static readonly IntPtr NativeFieldInfoPtr_tonemapping;

			// Token: 0x04007F8E RID: 32654
			private static readonly IntPtr NativeFieldInfoPtr_basic;

			// Token: 0x04007F8F RID: 32655
			private static readonly IntPtr NativeFieldInfoPtr_channelMixer;

			// Token: 0x04007F90 RID: 32656
			private static readonly IntPtr NativeFieldInfoPtr_colorWheels;

			// Token: 0x04007F91 RID: 32657
			private static readonly IntPtr NativeFieldInfoPtr_curves;

			// Token: 0x04007F92 RID: 32658
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;
		}
	}
}
