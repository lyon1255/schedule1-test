using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.WorldspacePopup
{
	// Token: 0x02000677 RID: 1655
	public class WorldspacePopupUI : MonoBehaviour
	{
		// Token: 0x060093CF RID: 37839 RVA: 0x00260274 File Offset: 0x0025E474
		// Note: this type is marked as 'beforefieldinit'.
		static WorldspacePopupUI()
		{
			Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.WorldspacePopup", "WorldspacePopupUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr);
			WorldspacePopupUI.NativeFieldInfoPtr_Popup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, "Popup");
			WorldspacePopupUI.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, "Rect");
			WorldspacePopupUI.NativeFieldInfoPtr_FillImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, "FillImage");
			WorldspacePopupUI.NativeFieldInfoPtr_onDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, "onDestroyed");
			WorldspacePopupUI.NativeMethodInfoPtr_SetFill_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, 100681615);
			WorldspacePopupUI.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, 100681616);
			WorldspacePopupUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, 100681617);
		}

		// Token: 0x060093D0 RID: 37840 RVA: 0x00260330 File Offset: 0x0025E530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265850, XrefRangeEnd = 265852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFill(float fill)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fill;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupUI.NativeMethodInfoPtr_SetFill_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093D1 RID: 37841 RVA: 0x00260370 File Offset: 0x0025E570
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 265858, RefRangeEnd = 265861, XrefRangeStart = 265852, XrefRangeEnd = 265858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupUI.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093D2 RID: 37842 RVA: 0x002603A4 File Offset: 0x0025E5A4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspacePopupUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093D3 RID: 37843 RVA: 0x00047AD5 File Offset: 0x00045CD5
		public WorldspacePopupUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D55 RID: 11605
		// (get) Token: 0x060093D4 RID: 37844 RVA: 0x002603E0 File Offset: 0x0025E5E0
		// (set) Token: 0x060093D5 RID: 37845 RVA: 0x00047ADE File Offset: 0x00045CDE
		public unsafe WorldspacePopup Popup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_Popup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_Popup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D56 RID: 11606
		// (get) Token: 0x060093D6 RID: 37846 RVA: 0x00260410 File Offset: 0x0025E610
		// (set) Token: 0x060093D7 RID: 37847 RVA: 0x00047AFD File Offset: 0x00045CFD
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D57 RID: 11607
		// (get) Token: 0x060093D8 RID: 37848 RVA: 0x00260440 File Offset: 0x0025E640
		// (set) Token: 0x060093D9 RID: 37849 RVA: 0x00047B1C File Offset: 0x00045D1C
		public unsafe Image FillImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_FillImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_FillImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D58 RID: 11608
		// (get) Token: 0x060093DA RID: 37850 RVA: 0x00260470 File Offset: 0x0025E670
		// (set) Token: 0x060093DB RID: 37851 RVA: 0x00047B3B File Offset: 0x00045D3B
		public unsafe UnityEvent onDestroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_onDestroyed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_onDestroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040063BF RID: 25535
		private static readonly IntPtr NativeFieldInfoPtr_Popup;

		// Token: 0x040063C0 RID: 25536
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x040063C1 RID: 25537
		private static readonly IntPtr NativeFieldInfoPtr_FillImage;

		// Token: 0x040063C2 RID: 25538
		private static readonly IntPtr NativeFieldInfoPtr_onDestroyed;

		// Token: 0x040063C3 RID: 25539
		private static readonly IntPtr NativeMethodInfoPtr_SetFill_Public_Void_Single_0;

		// Token: 0x040063C4 RID: 25540
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x040063C5 RID: 25541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
