using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Management.Presets.Options
{
	// Token: 0x020003AD RID: 941
	public class GenericOptionUI : MonoBehaviour
	{
		// Token: 0x0600498F RID: 18831 RVA: 0x00166590 File Offset: 0x00164790
		// Note: this type is marked as 'beforefieldinit'.
		static GenericOptionUI()
		{
			Il2CppClassPointerStore<GenericOptionUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.Presets.Options", "GenericOptionUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericOptionUI>.NativeClassPtr);
			GenericOptionUI.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOptionUI>.NativeClassPtr, "Button");
			GenericOptionUI.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOptionUI>.NativeClassPtr, "NameLabel");
			GenericOptionUI.NativeFieldInfoPtr_ValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOptionUI>.NativeClassPtr, "ValueLabel");
			GenericOptionUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOptionUI>.NativeClassPtr, 100672431);
		}

		// Token: 0x06004990 RID: 18832 RVA: 0x00166610 File Offset: 0x00164810
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericOptionUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericOptionUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericOptionUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004991 RID: 18833 RVA: 0x000236D2 File Offset: 0x000218D2
		public GenericOptionUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x06004992 RID: 18834 RVA: 0x0016664C File Offset: 0x0016484C
		// (set) Token: 0x06004993 RID: 18835 RVA: 0x000236DB File Offset: 0x000218DB
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionUI.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionUI.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x06004994 RID: 18836 RVA: 0x0016667C File Offset: 0x0016487C
		// (set) Token: 0x06004995 RID: 18837 RVA: 0x000236FA File Offset: 0x000218FA
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionUI.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionUI.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x06004996 RID: 18838 RVA: 0x001666AC File Offset: 0x001648AC
		// (set) Token: 0x06004997 RID: 18839 RVA: 0x00023719 File Offset: 0x00021919
		public unsafe TextMeshProUGUI ValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionUI.NativeFieldInfoPtr_ValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionUI.NativeFieldInfoPtr_ValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400319F RID: 12703
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x040031A0 RID: 12704
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x040031A1 RID: 12705
		private static readonly IntPtr NativeFieldInfoPtr_ValueLabel;

		// Token: 0x040031A2 RID: 12706
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
