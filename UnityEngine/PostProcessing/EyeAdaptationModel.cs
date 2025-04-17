using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000067 RID: 103
	[Serializable]
	public class EyeAdaptationModel : PostProcessingModel
	{
		// Token: 0x0600077D RID: 1917 RVA: 0x00087370 File Offset: 0x00085570
		// Note: this type is marked as 'beforefieldinit'.
		static EyeAdaptationModel()
		{
			Il2CppClassPointerStore<EyeAdaptationModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "EyeAdaptationModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeAdaptationModel>.NativeClassPtr);
			EyeAdaptationModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationModel>.NativeClassPtr, "m_Settings");
			EyeAdaptationModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationModel>.NativeClassPtr, 100664101);
			EyeAdaptationModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationModel>.NativeClassPtr, 100664102);
			EyeAdaptationModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationModel>.NativeClassPtr, 100664103);
			EyeAdaptationModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationModel>.NativeClassPtr, 100664104);
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x00087404 File Offset: 0x00085604
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x00087440 File Offset: 0x00085640
		public unsafe EyeAdaptationModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAdaptationModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAdaptationModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00087480 File Offset: 0x00085680
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EyeAdaptationModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x000874BC File Offset: 0x000856BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77880, XrefRangeEnd = 77881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EyeAdaptationModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyeAdaptationModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAdaptationModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00006154 File Offset: 0x00004354
		public EyeAdaptationModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x000874F8 File Offset: 0x000856F8
		// (set) Token: 0x06000784 RID: 1924 RVA: 0x0000615D File Offset: 0x0000435D
		public unsafe EyeAdaptationModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationModel.NativeFieldInfoPtr_m_Settings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationModel.NativeFieldInfoPtr_m_Settings)) = value;
			}
		}

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007F8 RID: 2040
		[OriginalName("Assembly-CSharp.dll", "", "EyeAdaptationType")]
		public enum EyeAdaptationType
		{
			// Token: 0x04007FA5 RID: 32677
			Progressive,
			// Token: 0x04007FA6 RID: 32678
			Fixed
		}

		// Token: 0x020007F9 RID: 2041
		[Serializable]
		[StructLayout(2)]
		public struct Settings
		{
			// Token: 0x0600BCBD RID: 48317 RVA: 0x002E835C File Offset: 0x002E655C
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EyeAdaptationModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr);
				EyeAdaptationModel.Settings.NativeFieldInfoPtr_lowPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr, "lowPercent");
				EyeAdaptationModel.Settings.NativeFieldInfoPtr_highPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr, "highPercent");
				EyeAdaptationModel.Settings.NativeFieldInfoPtr_minLuminance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr, "minLuminance");
				EyeAdaptationModel.Settings.NativeFieldInfoPtr_maxLuminance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr, "maxLuminance");
				EyeAdaptationModel.Settings.NativeFieldInfoPtr_keyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr, "keyValue");
				EyeAdaptationModel.Settings.NativeFieldInfoPtr_dynamicKeyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr, "dynamicKeyValue");
				EyeAdaptationModel.Settings.NativeFieldInfoPtr_adaptationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr, "adaptationType");
				EyeAdaptationModel.Settings.NativeFieldInfoPtr_speedUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr, "speedUp");
				EyeAdaptationModel.Settings.NativeFieldInfoPtr_speedDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr, "speedDown");
				EyeAdaptationModel.Settings.NativeFieldInfoPtr_logMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr, "logMin");
				EyeAdaptationModel.Settings.NativeFieldInfoPtr_logMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr, "logMax");
				EyeAdaptationModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr, 100664105);
			}

			// Token: 0x17003A83 RID: 14979
			// (get) Token: 0x0600BCBE RID: 48318 RVA: 0x002E8478 File Offset: 0x002E6678
			public unsafe static EyeAdaptationModel.Settings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAdaptationModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BCBF RID: 48319 RVA: 0x0005C5B0 File Offset: 0x0005A7B0
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EyeAdaptationModel.Settings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007FA7 RID: 32679
			private static readonly IntPtr NativeFieldInfoPtr_lowPercent;

			// Token: 0x04007FA8 RID: 32680
			private static readonly IntPtr NativeFieldInfoPtr_highPercent;

			// Token: 0x04007FA9 RID: 32681
			private static readonly IntPtr NativeFieldInfoPtr_minLuminance;

			// Token: 0x04007FAA RID: 32682
			private static readonly IntPtr NativeFieldInfoPtr_maxLuminance;

			// Token: 0x04007FAB RID: 32683
			private static readonly IntPtr NativeFieldInfoPtr_keyValue;

			// Token: 0x04007FAC RID: 32684
			private static readonly IntPtr NativeFieldInfoPtr_dynamicKeyValue;

			// Token: 0x04007FAD RID: 32685
			private static readonly IntPtr NativeFieldInfoPtr_adaptationType;

			// Token: 0x04007FAE RID: 32686
			private static readonly IntPtr NativeFieldInfoPtr_speedUp;

			// Token: 0x04007FAF RID: 32687
			private static readonly IntPtr NativeFieldInfoPtr_speedDown;

			// Token: 0x04007FB0 RID: 32688
			private static readonly IntPtr NativeFieldInfoPtr_logMin;

			// Token: 0x04007FB1 RID: 32689
			private static readonly IntPtr NativeFieldInfoPtr_logMax;

			// Token: 0x04007FB2 RID: 32690
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;

			// Token: 0x04007FB3 RID: 32691
			[FieldOffset(0)]
			public float lowPercent;

			// Token: 0x04007FB4 RID: 32692
			[FieldOffset(4)]
			public float highPercent;

			// Token: 0x04007FB5 RID: 32693
			[FieldOffset(8)]
			public float minLuminance;

			// Token: 0x04007FB6 RID: 32694
			[FieldOffset(12)]
			public float maxLuminance;

			// Token: 0x04007FB7 RID: 32695
			[FieldOffset(16)]
			public float keyValue;

			// Token: 0x04007FB8 RID: 32696
			[FieldOffset(20)]
			[MarshalAs(4)]
			public bool dynamicKeyValue;

			// Token: 0x04007FB9 RID: 32697
			[FieldOffset(24)]
			public EyeAdaptationModel.EyeAdaptationType adaptationType;

			// Token: 0x04007FBA RID: 32698
			[FieldOffset(28)]
			public float speedUp;

			// Token: 0x04007FBB RID: 32699
			[FieldOffset(32)]
			public float speedDown;

			// Token: 0x04007FBC RID: 32700
			[FieldOffset(36)]
			public int logMin;

			// Token: 0x04007FBD RID: 32701
			[FieldOffset(40)]
			public int logMax;
		}
	}
}
