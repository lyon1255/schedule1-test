using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200005F RID: 95
	[Serializable]
	public class AmbientOcclusionModel : PostProcessingModel
	{
		// Token: 0x06000732 RID: 1842 RVA: 0x000862FC File Offset: 0x000844FC
		// Note: this type is marked as 'beforefieldinit'.
		static AmbientOcclusionModel()
		{
			Il2CppClassPointerStore<AmbientOcclusionModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "AmbientOcclusionModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientOcclusionModel>.NativeClassPtr);
			AmbientOcclusionModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionModel>.NativeClassPtr, "m_Settings");
			AmbientOcclusionModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionModel>.NativeClassPtr, 100664037);
			AmbientOcclusionModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionModel>.NativeClassPtr, 100664038);
			AmbientOcclusionModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionModel>.NativeClassPtr, 100664039);
			AmbientOcclusionModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionModel>.NativeClassPtr, 100664040);
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x00086390 File Offset: 0x00084590
		// (set) Token: 0x06000734 RID: 1844 RVA: 0x000863CC File Offset: 0x000845CC
		public unsafe AmbientOcclusionModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusionModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusionModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0008640C File Offset: 0x0008460C
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AmbientOcclusionModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00086448 File Offset: 0x00084648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77735, XrefRangeEnd = 77736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbientOcclusionModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbientOcclusionModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusionModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00005FC1 File Offset: 0x000041C1
		public AmbientOcclusionModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x00086484 File Offset: 0x00084684
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x00005FCA File Offset: 0x000041CA
		public unsafe AmbientOcclusionModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusionModel.NativeFieldInfoPtr_m_Settings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusionModel.NativeFieldInfoPtr_m_Settings)) = value;
			}
		}

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007DA RID: 2010
		[OriginalName("Assembly-CSharp.dll", "", "SampleCount")]
		public enum SampleCount
		{
			// Token: 0x04007EC7 RID: 32455
			Lowest = 3,
			// Token: 0x04007EC8 RID: 32456
			Low = 6,
			// Token: 0x04007EC9 RID: 32457
			Medium = 10,
			// Token: 0x04007ECA RID: 32458
			High = 16
		}

		// Token: 0x020007DB RID: 2011
		[Serializable]
		[StructLayout(2)]
		public struct Settings
		{
			// Token: 0x0600BC3F RID: 48191 RVA: 0x002E6DD4 File Offset: 0x002E4FD4
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<AmbientOcclusionModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AmbientOcclusionModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientOcclusionModel.Settings>.NativeClassPtr);
				AmbientOcclusionModel.Settings.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionModel.Settings>.NativeClassPtr, "intensity");
				AmbientOcclusionModel.Settings.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionModel.Settings>.NativeClassPtr, "radius");
				AmbientOcclusionModel.Settings.NativeFieldInfoPtr_sampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionModel.Settings>.NativeClassPtr, "sampleCount");
				AmbientOcclusionModel.Settings.NativeFieldInfoPtr_downsampling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionModel.Settings>.NativeClassPtr, "downsampling");
				AmbientOcclusionModel.Settings.NativeFieldInfoPtr_forceForwardCompatibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionModel.Settings>.NativeClassPtr, "forceForwardCompatibility");
				AmbientOcclusionModel.Settings.NativeFieldInfoPtr_ambientOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionModel.Settings>.NativeClassPtr, "ambientOnly");
				AmbientOcclusionModel.Settings.NativeFieldInfoPtr_highPrecision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionModel.Settings>.NativeClassPtr, "highPrecision");
				AmbientOcclusionModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionModel.Settings>.NativeClassPtr, 100664041);
			}

			// Token: 0x17003A53 RID: 14931
			// (get) Token: 0x0600BC40 RID: 48192 RVA: 0x002E6EA0 File Offset: 0x002E50A0
			public unsafe static AmbientOcclusionModel.Settings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusionModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BC41 RID: 48193 RVA: 0x0005C0B7 File Offset: 0x0005A2B7
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AmbientOcclusionModel.Settings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007ECB RID: 32459
			private static readonly IntPtr NativeFieldInfoPtr_intensity;

			// Token: 0x04007ECC RID: 32460
			private static readonly IntPtr NativeFieldInfoPtr_radius;

			// Token: 0x04007ECD RID: 32461
			private static readonly IntPtr NativeFieldInfoPtr_sampleCount;

			// Token: 0x04007ECE RID: 32462
			private static readonly IntPtr NativeFieldInfoPtr_downsampling;

			// Token: 0x04007ECF RID: 32463
			private static readonly IntPtr NativeFieldInfoPtr_forceForwardCompatibility;

			// Token: 0x04007ED0 RID: 32464
			private static readonly IntPtr NativeFieldInfoPtr_ambientOnly;

			// Token: 0x04007ED1 RID: 32465
			private static readonly IntPtr NativeFieldInfoPtr_highPrecision;

			// Token: 0x04007ED2 RID: 32466
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;

			// Token: 0x04007ED3 RID: 32467
			[FieldOffset(0)]
			public float intensity;

			// Token: 0x04007ED4 RID: 32468
			[FieldOffset(4)]
			public float radius;

			// Token: 0x04007ED5 RID: 32469
			[FieldOffset(8)]
			public AmbientOcclusionModel.SampleCount sampleCount;

			// Token: 0x04007ED6 RID: 32470
			[FieldOffset(12)]
			[MarshalAs(4)]
			public bool downsampling;

			// Token: 0x04007ED7 RID: 32471
			[FieldOffset(13)]
			[MarshalAs(4)]
			public bool forceForwardCompatibility;

			// Token: 0x04007ED8 RID: 32472
			[FieldOffset(14)]
			[MarshalAs(4)]
			public bool ambientOnly;

			// Token: 0x04007ED9 RID: 32473
			[FieldOffset(15)]
			[MarshalAs(4)]
			public bool highPrecision;
		}
	}
}
