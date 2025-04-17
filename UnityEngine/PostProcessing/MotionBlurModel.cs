using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200006A RID: 106
	[Serializable]
	public class MotionBlurModel : PostProcessingModel
	{
		// Token: 0x06000795 RID: 1941 RVA: 0x00087880 File Offset: 0x00085A80
		// Note: this type is marked as 'beforefieldinit'.
		static MotionBlurModel()
		{
			Il2CppClassPointerStore<MotionBlurModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "MotionBlurModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionBlurModel>.NativeClassPtr);
			MotionBlurModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurModel>.NativeClassPtr, "m_Settings");
			MotionBlurModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurModel>.NativeClassPtr, 100664116);
			MotionBlurModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurModel>.NativeClassPtr, 100664117);
			MotionBlurModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurModel>.NativeClassPtr, 100664118);
			MotionBlurModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurModel>.NativeClassPtr, 100664119);
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x00087914 File Offset: 0x00085B14
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x00087950 File Offset: 0x00085B50
		public unsafe MotionBlurModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00087990 File Offset: 0x00085B90
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MotionBlurModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x000879CC File Offset: 0x00085BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77883, XrefRangeEnd = 77884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MotionBlurModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotionBlurModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x000061C0 File Offset: 0x000043C0
		public MotionBlurModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x00087A08 File Offset: 0x00085C08
		// (set) Token: 0x0600079C RID: 1948 RVA: 0x000061C9 File Offset: 0x000043C9
		public unsafe MotionBlurModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurModel.NativeFieldInfoPtr_m_Settings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotionBlurModel.NativeFieldInfoPtr_m_Settings)) = value;
			}
		}

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007FC RID: 2044
		[Serializable]
		[StructLayout(2)]
		public struct Settings
		{
			// Token: 0x0600BCC6 RID: 48326 RVA: 0x002E85EC File Offset: 0x002E67EC
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<MotionBlurModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MotionBlurModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionBlurModel.Settings>.NativeClassPtr);
				MotionBlurModel.Settings.NativeFieldInfoPtr_shutterAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurModel.Settings>.NativeClassPtr, "shutterAngle");
				MotionBlurModel.Settings.NativeFieldInfoPtr_sampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurModel.Settings>.NativeClassPtr, "sampleCount");
				MotionBlurModel.Settings.NativeFieldInfoPtr_frameBlending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionBlurModel.Settings>.NativeClassPtr, "frameBlending");
				MotionBlurModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurModel.Settings>.NativeClassPtr, 100664120);
			}

			// Token: 0x17003A86 RID: 14982
			// (get) Token: 0x0600BCC7 RID: 48327 RVA: 0x002E8668 File Offset: 0x002E6868
			public unsafe static MotionBlurModel.Settings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BCC8 RID: 48328 RVA: 0x0005C5E6 File Offset: 0x0005A7E6
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MotionBlurModel.Settings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007FCA RID: 32714
			private static readonly IntPtr NativeFieldInfoPtr_shutterAngle;

			// Token: 0x04007FCB RID: 32715
			private static readonly IntPtr NativeFieldInfoPtr_sampleCount;

			// Token: 0x04007FCC RID: 32716
			private static readonly IntPtr NativeFieldInfoPtr_frameBlending;

			// Token: 0x04007FCD RID: 32717
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;

			// Token: 0x04007FCE RID: 32718
			[FieldOffset(0)]
			public float shutterAngle;

			// Token: 0x04007FCF RID: 32719
			[FieldOffset(4)]
			public int sampleCount;

			// Token: 0x04007FD0 RID: 32720
			[FieldOffset(8)]
			public float frameBlending;
		}
	}
}
