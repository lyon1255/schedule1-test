using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts.WateringCan;
using Il2CppTMPro;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x0200071D RID: 1821
	public class TrashGrabberItemUI : ItemUI
	{
		// Token: 0x0600A3C6 RID: 41926 RVA: 0x00291254 File Offset: 0x0028F454
		// Note: this type is marked as 'beforefieldinit'.
		static TrashGrabberItemUI()
		{
			Il2CppClassPointerStore<TrashGrabberItemUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "TrashGrabberItemUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashGrabberItemUI>.NativeClassPtr);
			TrashGrabberItemUI.NativeFieldInfoPtr_ValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGrabberItemUI>.NativeClassPtr, "ValueLabel");
			TrashGrabberItemUI.NativeFieldInfoPtr_trashGrabberInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGrabberItemUI>.NativeClassPtr, "trashGrabberInstance");
			TrashGrabberItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberItemUI>.NativeClassPtr, 100683318);
			TrashGrabberItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberItemUI>.NativeClassPtr, 100683319);
			TrashGrabberItemUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberItemUI>.NativeClassPtr, 100683320);
		}

		// Token: 0x0600A3C7 RID: 41927 RVA: 0x002912E8 File Offset: 0x0028F4E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286392, XrefRangeEnd = 286400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Setup(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashGrabberItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3C8 RID: 41928 RVA: 0x00291338 File Offset: 0x0028F538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286400, XrefRangeEnd = 286411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashGrabberItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3C9 RID: 41929 RVA: 0x00291374 File Offset: 0x0028F574
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashGrabberItemUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashGrabberItemUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberItemUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3CA RID: 41930 RVA: 0x00050ACE File Offset: 0x0004ECCE
		public TrashGrabberItemUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003284 RID: 12932
		// (get) Token: 0x0600A3CB RID: 41931 RVA: 0x002913B0 File Offset: 0x0028F5B0
		// (set) Token: 0x0600A3CC RID: 41932 RVA: 0x00050AD7 File Offset: 0x0004ECD7
		public unsafe TextMeshProUGUI ValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGrabberItemUI.NativeFieldInfoPtr_ValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGrabberItemUI.NativeFieldInfoPtr_ValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003285 RID: 12933
		// (get) Token: 0x0600A3CD RID: 41933 RVA: 0x002913E0 File Offset: 0x0028F5E0
		// (set) Token: 0x0600A3CE RID: 41934 RVA: 0x00050AF6 File Offset: 0x0004ECF6
		public unsafe TrashGrabberInstance trashGrabberInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGrabberItemUI.NativeFieldInfoPtr_trashGrabberInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashGrabberInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGrabberItemUI.NativeFieldInfoPtr_trashGrabberInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006DCF RID: 28111
		private static readonly IntPtr NativeFieldInfoPtr_ValueLabel;

		// Token: 0x04006DD0 RID: 28112
		private static readonly IntPtr NativeFieldInfoPtr_trashGrabberInstance;

		// Token: 0x04006DD1 RID: 28113
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04006DD2 RID: 28114
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0;

		// Token: 0x04006DD3 RID: 28115
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
