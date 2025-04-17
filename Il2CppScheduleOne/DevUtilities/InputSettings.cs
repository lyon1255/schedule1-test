using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000473 RID: 1139
	[Serializable]
	public class InputSettings : Object
	{
		// Token: 0x06006263 RID: 25187 RVA: 0x001BF568 File Offset: 0x001BD768
		// Note: this type is marked as 'beforefieldinit'.
		static InputSettings()
		{
			Il2CppClassPointerStore<InputSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "InputSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputSettings>.NativeClassPtr);
			InputSettings.NativeFieldInfoPtr_MouseSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSettings>.NativeClassPtr, "MouseSensitivity");
			InputSettings.NativeFieldInfoPtr_InvertMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSettings>.NativeClassPtr, "InvertMouse");
			InputSettings.NativeFieldInfoPtr_SprintMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSettings>.NativeClassPtr, "SprintMode");
			InputSettings.NativeFieldInfoPtr_BindingOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSettings>.NativeClassPtr, "BindingOverrides");
			InputSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSettings>.NativeClassPtr, 100675771);
		}

		// Token: 0x06006264 RID: 25188 RVA: 0x001BF5FC File Offset: 0x001BD7FC
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006265 RID: 25189 RVA: 0x0002E834 File Offset: 0x0002CA34
		public InputSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D97 RID: 7575
		// (get) Token: 0x06006266 RID: 25190 RVA: 0x001BF638 File Offset: 0x001BD838
		// (set) Token: 0x06006267 RID: 25191 RVA: 0x0002E83D File Offset: 0x0002CA3D
		public unsafe float MouseSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_MouseSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_MouseSensitivity)) = value;
			}
		}

		// Token: 0x17001D98 RID: 7576
		// (get) Token: 0x06006268 RID: 25192 RVA: 0x001BF660 File Offset: 0x001BD860
		// (set) Token: 0x06006269 RID: 25193 RVA: 0x0002E858 File Offset: 0x0002CA58
		public unsafe bool InvertMouse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_InvertMouse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_InvertMouse)) = value;
			}
		}

		// Token: 0x17001D99 RID: 7577
		// (get) Token: 0x0600626A RID: 25194 RVA: 0x001BF688 File Offset: 0x001BD888
		// (set) Token: 0x0600626B RID: 25195 RVA: 0x0002E873 File Offset: 0x0002CA73
		public unsafe InputSettings.EActionMode SprintMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_SprintMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_SprintMode)) = value;
			}
		}

		// Token: 0x17001D9A RID: 7578
		// (get) Token: 0x0600626C RID: 25196 RVA: 0x001BF6B0 File Offset: 0x001BD8B0
		// (set) Token: 0x0600626D RID: 25197 RVA: 0x0002E88E File Offset: 0x0002CA8E
		public unsafe string BindingOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_BindingOverrides);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_BindingOverrides), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400431A RID: 17178
		private static readonly IntPtr NativeFieldInfoPtr_MouseSensitivity;

		// Token: 0x0400431B RID: 17179
		private static readonly IntPtr NativeFieldInfoPtr_InvertMouse;

		// Token: 0x0400431C RID: 17180
		private static readonly IntPtr NativeFieldInfoPtr_SprintMode;

		// Token: 0x0400431D RID: 17181
		private static readonly IntPtr NativeFieldInfoPtr_BindingOverrides;

		// Token: 0x0400431E RID: 17182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A1F RID: 2591
		[OriginalName("Assembly-CSharp.dll", "", "EActionMode")]
		public enum EActionMode
		{
			// Token: 0x04008BB0 RID: 35760
			Press,
			// Token: 0x04008BB1 RID: 35761
			Hold
		}
	}
}
