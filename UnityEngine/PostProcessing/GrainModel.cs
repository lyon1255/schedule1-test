using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000069 RID: 105
	[Serializable]
	public class GrainModel : PostProcessingModel
	{
		// Token: 0x0600078D RID: 1933 RVA: 0x000876D0 File Offset: 0x000858D0
		// Note: this type is marked as 'beforefieldinit'.
		static GrainModel()
		{
			Il2CppClassPointerStore<GrainModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "GrainModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrainModel>.NativeClassPtr);
			GrainModel.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrainModel>.NativeClassPtr, "m_Settings");
			GrainModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrainModel>.NativeClassPtr, 100664111);
			GrainModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrainModel>.NativeClassPtr, 100664112);
			GrainModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrainModel>.NativeClassPtr, 100664113);
			GrainModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrainModel>.NativeClassPtr, 100664114);
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x00087764 File Offset: 0x00085964
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x000877A0 File Offset: 0x000859A0
		public unsafe GrainModel.Settings settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrainModel.NativeMethodInfoPtr_get_settings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrainModel.NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x000877E0 File Offset: 0x000859E0
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrainModel.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0008781C File Offset: 0x00085A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77882, XrefRangeEnd = 77883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GrainModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrainModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrainModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0000619C File Offset: 0x0000439C
		public GrainModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x00087858 File Offset: 0x00085A58
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x000061A5 File Offset: 0x000043A5
		public unsafe GrainModel.Settings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrainModel.NativeFieldInfoPtr_m_Settings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrainModel.NativeFieldInfoPtr_m_Settings)) = value;
			}
		}

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeMethodInfoPtr_get_settings_Public_get_Settings_0;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeMethodInfoPtr_set_settings_Public_set_Void_Settings_0;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007FB RID: 2043
		[Serializable]
		[StructLayout(2)]
		public struct Settings
		{
			// Token: 0x0600BCC3 RID: 48323 RVA: 0x002E852C File Offset: 0x002E672C
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<GrainModel.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GrainModel>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrainModel.Settings>.NativeClassPtr);
				GrainModel.Settings.NativeFieldInfoPtr_colored = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrainModel.Settings>.NativeClassPtr, "colored");
				GrainModel.Settings.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrainModel.Settings>.NativeClassPtr, "intensity");
				GrainModel.Settings.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrainModel.Settings>.NativeClassPtr, "size");
				GrainModel.Settings.NativeFieldInfoPtr_luminanceContribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrainModel.Settings>.NativeClassPtr, "luminanceContribution");
				GrainModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrainModel.Settings>.NativeClassPtr, 100664115);
			}

			// Token: 0x17003A85 RID: 14981
			// (get) Token: 0x0600BCC4 RID: 48324 RVA: 0x002E85BC File Offset: 0x002E67BC
			public unsafe static GrainModel.Settings defaultSettings
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrainModel.Settings.NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BCC5 RID: 48325 RVA: 0x0005C5D4 File Offset: 0x0005A7D4
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GrainModel.Settings>.NativeClassPtr, ref this));
			}

			// Token: 0x04007FC1 RID: 32705
			private static readonly IntPtr NativeFieldInfoPtr_colored;

			// Token: 0x04007FC2 RID: 32706
			private static readonly IntPtr NativeFieldInfoPtr_intensity;

			// Token: 0x04007FC3 RID: 32707
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x04007FC4 RID: 32708
			private static readonly IntPtr NativeFieldInfoPtr_luminanceContribution;

			// Token: 0x04007FC5 RID: 32709
			private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_Settings_0;

			// Token: 0x04007FC6 RID: 32710
			[FieldOffset(0)]
			[MarshalAs(4)]
			public bool colored;

			// Token: 0x04007FC7 RID: 32711
			[FieldOffset(4)]
			public float intensity;

			// Token: 0x04007FC8 RID: 32712
			[FieldOffset(8)]
			public float size;

			// Token: 0x04007FC9 RID: 32713
			[FieldOffset(12)]
			public float luminanceContribution;
		}
	}
}
