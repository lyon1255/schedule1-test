using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200006B RID: 107
	[Serializable]
	public class ScreenSpaceReflectionModel : PostProcessingModel
	{
		// Token: 0x0600079D RID: 1949 RVA: 0x00087A30 File Offset: 0x00085C30
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenSpaceReflectionModel()
		{
			Il2CppClassPointerStore<ScreenSpaceReflectionModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "ScreenSpaceReflectionModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceReflectionModel>.NativeClassPtr);
			ScreenSpaceReflectionModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel>.NativeClassPtr, "m_Settings");
			ScreenSpaceReflectionModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionModel>.NativeClassPtr, 100664121);
			ScreenSpaceReflectionModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionModel>.NativeClassPtr, 100664122);
			ScreenSpaceReflectionModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionModel>.NativeClassPtr, 100664123);
			ScreenSpaceReflectionModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionModel>.NativeClassPtr, 100664124);
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x00087AC4 File Offset: 0x00085CC4
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x00087B00 File Offset: 0x00085D00
		public unsafe ScreenSpaceReflectionModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00087B40 File Offset: 0x00085D40
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScreenSpaceReflectionModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00087B7C File Offset: 0x00085D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77884, XrefRangeEnd = 77885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScreenSpaceReflectionModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenSpaceReflectionModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x000061E4 File Offset: 0x000043E4
		public ScreenSpaceReflectionModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x00087BB8 File Offset: 0x00085DB8
		// (set) Token: 0x060007A4 RID: 1956 RVA: 0x000061ED File Offset: 0x000043ED
		public unsafe ScreenSpaceReflectionModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionModel.NativeFieldInfoPtr_m_Settings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflectionModel.NativeFieldInfoPtr_m_Settings)) = value;
			}
		}

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007FD RID: 2045
		[OriginalName("Assembly-CSharp.dll", "", "SSRResolution")]
		public enum SSRResolution
		{
			// Token: 0x04007FD2 RID: 32722
			High,
			// Token: 0x04007FD3 RID: 32723
			Low = 2
		}

		// Token: 0x020007FE RID: 2046
		[OriginalName("Assembly-CSharp.dll", "", "SSRReflectionBlendType")]
		public enum SSRReflectionBlendType
		{
			// Token: 0x04007FD5 RID: 32725
			PhysicallyBased,
			// Token: 0x04007FD6 RID: 32726
			Additive
		}

		// Token: 0x020007FF RID: 2047
		[Serializable]
		[StructLayout(2)]
		public struct IntensitySettings
		{
			// Token: 0x0600BCC9 RID: 48329 RVA: 0x002E8698 File Offset: 0x002E6898
			// Note: this type is marked as 'beforefieldinit'.
			static IntensitySettings()
			{
				Il2CppClassPointerStore<ScreenSpaceReflectionModel.IntensitySettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenSpaceReflectionModel>.NativeClassPtr, "IntensitySettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceReflectionModel.IntensitySettings>.NativeClassPtr);
				ScreenSpaceReflectionModel.IntensitySettings.NativeFieldInfoPtr_reflectionMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.IntensitySettings>.NativeClassPtr, "reflectionMultiplier");
				ScreenSpaceReflectionModel.IntensitySettings.NativeFieldInfoPtr_fadeDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.IntensitySettings>.NativeClassPtr, "fadeDistance");
				ScreenSpaceReflectionModel.IntensitySettings.NativeFieldInfoPtr_fresnelFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.IntensitySettings>.NativeClassPtr, "fresnelFade");
				ScreenSpaceReflectionModel.IntensitySettings.NativeFieldInfoPtr_fresnelFadePower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.IntensitySettings>.NativeClassPtr, "fresnelFadePower");
			}

			// Token: 0x0600BCCA RID: 48330 RVA: 0x0005C5F8 File Offset: 0x0005A7F8
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenSpaceReflectionModel.IntensitySettings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007FD7 RID: 32727
			private static readonly IntPtr NativeFieldInfoPtr_reflectionMultiplier;

			// Token: 0x04007FD8 RID: 32728
			private static readonly IntPtr NativeFieldInfoPtr_fadeDistance;

			// Token: 0x04007FD9 RID: 32729
			private static readonly IntPtr NativeFieldInfoPtr_fresnelFade;

			// Token: 0x04007FDA RID: 32730
			private static readonly IntPtr NativeFieldInfoPtr_fresnelFadePower;

			// Token: 0x04007FDB RID: 32731
			[FieldOffset(0)]
			public float reflectionMultiplier;

			// Token: 0x04007FDC RID: 32732
			[FieldOffset(4)]
			public float fadeDistance;

			// Token: 0x04007FDD RID: 32733
			[FieldOffset(8)]
			public float fresnelFade;

			// Token: 0x04007FDE RID: 32734
			[FieldOffset(12)]
			public float fresnelFadePower;
		}

		// Token: 0x02000800 RID: 2048
		[Serializable]
		[StructLayout(2)]
		public struct ReflectionSettings
		{
			// Token: 0x0600BCCB RID: 48331 RVA: 0x002E8714 File Offset: 0x002E6914
			// Note: this type is marked as 'beforefieldinit'.
			static ReflectionSettings()
			{
				Il2CppClassPointerStore<ScreenSpaceReflectionModel.ReflectionSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenSpaceReflectionModel>.NativeClassPtr, "ReflectionSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceReflectionModel.ReflectionSettings>.NativeClassPtr);
				ScreenSpaceReflectionModel.ReflectionSettings.NativeFieldInfoPtr_blendType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.ReflectionSettings>.NativeClassPtr, "blendType");
				ScreenSpaceReflectionModel.ReflectionSettings.NativeFieldInfoPtr_reflectionQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.ReflectionSettings>.NativeClassPtr, "reflectionQuality");
				ScreenSpaceReflectionModel.ReflectionSettings.NativeFieldInfoPtr_maxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.ReflectionSettings>.NativeClassPtr, "maxDistance");
				ScreenSpaceReflectionModel.ReflectionSettings.NativeFieldInfoPtr_iterationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.ReflectionSettings>.NativeClassPtr, "iterationCount");
				ScreenSpaceReflectionModel.ReflectionSettings.NativeFieldInfoPtr_stepSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.ReflectionSettings>.NativeClassPtr, "stepSize");
				ScreenSpaceReflectionModel.ReflectionSettings.NativeFieldInfoPtr_widthModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.ReflectionSettings>.NativeClassPtr, "widthModifier");
				ScreenSpaceReflectionModel.ReflectionSettings.NativeFieldInfoPtr_reflectionBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.ReflectionSettings>.NativeClassPtr, "reflectionBlur");
				ScreenSpaceReflectionModel.ReflectionSettings.NativeFieldInfoPtr_reflectBackfaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.ReflectionSettings>.NativeClassPtr, "reflectBackfaces");
			}

			// Token: 0x0600BCCC RID: 48332 RVA: 0x0005C60A File Offset: 0x0005A80A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenSpaceReflectionModel.ReflectionSettings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007FDF RID: 32735
			private static readonly IntPtr NativeFieldInfoPtr_blendType;

			// Token: 0x04007FE0 RID: 32736
			private static readonly IntPtr NativeFieldInfoPtr_reflectionQuality;

			// Token: 0x04007FE1 RID: 32737
			private static readonly IntPtr NativeFieldInfoPtr_maxDistance;

			// Token: 0x04007FE2 RID: 32738
			private static readonly IntPtr NativeFieldInfoPtr_iterationCount;

			// Token: 0x04007FE3 RID: 32739
			private static readonly IntPtr NativeFieldInfoPtr_stepSize;

			// Token: 0x04007FE4 RID: 32740
			private static readonly IntPtr NativeFieldInfoPtr_widthModifier;

			// Token: 0x04007FE5 RID: 32741
			private static readonly IntPtr NativeFieldInfoPtr_reflectionBlur;

			// Token: 0x04007FE6 RID: 32742
			private static readonly IntPtr NativeFieldInfoPtr_reflectBackfaces;

			// Token: 0x04007FE7 RID: 32743
			[FieldOffset(0)]
			public ScreenSpaceReflectionModel.SSRReflectionBlendType blendType;

			// Token: 0x04007FE8 RID: 32744
			[FieldOffset(4)]
			public ScreenSpaceReflectionModel.SSRResolution reflectionQuality;

			// Token: 0x04007FE9 RID: 32745
			[FieldOffset(8)]
			public float maxDistance;

			// Token: 0x04007FEA RID: 32746
			[FieldOffset(12)]
			public int iterationCount;

			// Token: 0x04007FEB RID: 32747
			[FieldOffset(16)]
			public int stepSize;

			// Token: 0x04007FEC RID: 32748
			[FieldOffset(20)]
			public float widthModifier;

			// Token: 0x04007FED RID: 32749
			[FieldOffset(24)]
			public float reflectionBlur;

			// Token: 0x04007FEE RID: 32750
			[FieldOffset(28)]
			[MarshalAs(4)]
			public bool reflectBackfaces;
		}

		// Token: 0x02000801 RID: 2049
		[Serializable]
		[StructLayout(2)]
		public struct ScreenEdgeMask
		{
			// Token: 0x0600BCCD RID: 48333 RVA: 0x0005C61C File Offset: 0x0005A81C
			// Note: this type is marked as 'beforefieldinit'.
			static ScreenEdgeMask()
			{
				Il2CppClassPointerStore<ScreenSpaceReflectionModel.ScreenEdgeMask>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenSpaceReflectionModel>.NativeClassPtr, "ScreenEdgeMask");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceReflectionModel.ScreenEdgeMask>.NativeClassPtr);
				ScreenSpaceReflectionModel.ScreenEdgeMask.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.ScreenEdgeMask>.NativeClassPtr, "intensity");
			}

			// Token: 0x0600BCCE RID: 48334 RVA: 0x0005C650 File Offset: 0x0005A850
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenSpaceReflectionModel.ScreenEdgeMask>.NativeClassPtr, ref this));
			}

			// Token: 0x04007FEF RID: 32751
			private static readonly IntPtr NativeFieldInfoPtr_intensity;

			// Token: 0x04007FF0 RID: 32752
			[FieldOffset(0)]
			public float intensity;
		}

		// Token: 0x02000802 RID: 2050
		[Serializable]
		[StructLayout(2)]
		public struct Settings
		{
			// Token: 0x0600BCCF RID: 48335 RVA: 0x002E87E0 File Offset: 0x002E69E0
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<ScreenSpaceReflectionModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenSpaceReflectionModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceReflectionModel.Settings>.NativeClassPtr);
				ScreenSpaceReflectionModel.Settings.NativeFieldInfoPtr_reflection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.Settings>.NativeClassPtr, "reflection");
				ScreenSpaceReflectionModel.Settings.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.Settings>.NativeClassPtr, "intensity");
				ScreenSpaceReflectionModel.Settings.NativeFieldInfoPtr_screenEdgeMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflectionModel.Settings>.NativeClassPtr, "screenEdgeMask");
				ScreenSpaceReflectionModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflectionModel.Settings>.NativeClassPtr, 100664125);
			}

			// Token: 0x17003A87 RID: 14983
			// (get) Token: 0x0600BCD0 RID: 48336 RVA: 0x002E885C File Offset: 0x002E6A5C
			public unsafe static ScreenSpaceReflectionModel.Settings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflectionModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BCD1 RID: 48337 RVA: 0x0005C662 File Offset: 0x0005A862
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenSpaceReflectionModel.Settings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007FF1 RID: 32753
			private static readonly IntPtr NativeFieldInfoPtr_reflection;

			// Token: 0x04007FF2 RID: 32754
			private static readonly IntPtr NativeFieldInfoPtr_intensity;

			// Token: 0x04007FF3 RID: 32755
			private static readonly IntPtr NativeFieldInfoPtr_screenEdgeMask;

			// Token: 0x04007FF4 RID: 32756
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;

			// Token: 0x04007FF5 RID: 32757
			[FieldOffset(0)]
			public ScreenSpaceReflectionModel.ReflectionSettings reflection;

			// Token: 0x04007FF6 RID: 32758
			[FieldOffset(32)]
			public ScreenSpaceReflectionModel.IntensitySettings intensity;

			// Token: 0x04007FF7 RID: 32759
			[FieldOffset(48)]
			public ScreenSpaceReflectionModel.ScreenEdgeMask screenEdgeMask;
		}
	}
}
