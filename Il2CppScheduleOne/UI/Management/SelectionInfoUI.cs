using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006D3 RID: 1747
	public class SelectionInfoUI : MonoBehaviour
	{
		// Token: 0x06009D31 RID: 40241 RVA: 0x0027C690 File Offset: 0x0027A890
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionInfoUI()
		{
			Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "SelectionInfoUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr);
			SelectionInfoUI.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, "Icon");
			SelectionInfoUI.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, "Title");
			SelectionInfoUI.NativeFieldInfoPtr_SelfUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, "SelfUpdate");
			SelectionInfoUI.NativeFieldInfoPtr_NonUniformTypeSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, "NonUniformTypeSprite");
			SelectionInfoUI.NativeFieldInfoPtr_CrossSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, "CrossSprite");
			SelectionInfoUI.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, 100682588);
			SelectionInfoUI.NativeMethodInfoPtr_Set_Public_Void_List_1_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, 100682589);
			SelectionInfoUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr, 100682590);
		}

		// Token: 0x06009D32 RID: 40242 RVA: 0x0027C760 File Offset: 0x0027A960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278907, XrefRangeEnd = 278934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionInfoUI.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D33 RID: 40243 RVA: 0x0027C794 File Offset: 0x0027A994
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278967, RefRangeEnd = 278969, XrefRangeStart = 278934, XrefRangeEnd = 278967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(List<IConfigurable> Configurables)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(Configurables);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionInfoUI.NativeMethodInfoPtr_Set_Public_Void_List_1_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D34 RID: 40244 RVA: 0x0027C7D8 File Offset: 0x0027A9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278969, XrefRangeEnd = 278970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionInfoUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionInfoUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionInfoUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D35 RID: 40245 RVA: 0x0004D1CF File Offset: 0x0004B3CF
		public SelectionInfoUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003069 RID: 12393
		// (get) Token: 0x06009D36 RID: 40246 RVA: 0x0027C814 File Offset: 0x0027AA14
		// (set) Token: 0x06009D37 RID: 40247 RVA: 0x0004D1D8 File Offset: 0x0004B3D8
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700306A RID: 12394
		// (get) Token: 0x06009D38 RID: 40248 RVA: 0x0027C844 File Offset: 0x0027AA44
		// (set) Token: 0x06009D39 RID: 40249 RVA: 0x0004D1F7 File Offset: 0x0004B3F7
		public unsafe TextMeshProUGUI Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_Title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700306B RID: 12395
		// (get) Token: 0x06009D3A RID: 40250 RVA: 0x0027C874 File Offset: 0x0027AA74
		// (set) Token: 0x06009D3B RID: 40251 RVA: 0x0004D216 File Offset: 0x0004B416
		public unsafe bool SelfUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_SelfUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_SelfUpdate)) = value;
			}
		}

		// Token: 0x1700306C RID: 12396
		// (get) Token: 0x06009D3C RID: 40252 RVA: 0x0027C89C File Offset: 0x0027AA9C
		// (set) Token: 0x06009D3D RID: 40253 RVA: 0x0004D231 File Offset: 0x0004B431
		public unsafe Sprite NonUniformTypeSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_NonUniformTypeSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_NonUniformTypeSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700306D RID: 12397
		// (get) Token: 0x06009D3E RID: 40254 RVA: 0x0027C8CC File Offset: 0x0027AACC
		// (set) Token: 0x06009D3F RID: 40255 RVA: 0x0004D250 File Offset: 0x0004B450
		public unsafe Sprite CrossSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_CrossSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionInfoUI.NativeFieldInfoPtr_CrossSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006991 RID: 27025
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x04006992 RID: 27026
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x04006993 RID: 27027
		private static readonly IntPtr NativeFieldInfoPtr_SelfUpdate;

		// Token: 0x04006994 RID: 27028
		private static readonly IntPtr NativeFieldInfoPtr_NonUniformTypeSprite;

		// Token: 0x04006995 RID: 27029
		private static readonly IntPtr NativeFieldInfoPtr_CrossSprite;

		// Token: 0x04006996 RID: 27030
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006997 RID: 27031
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_List_1_IConfigurable_0;

		// Token: 0x04006998 RID: 27032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
