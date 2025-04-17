using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x0200070F RID: 1807
	public class ShopInterfaceDetailPanel : MonoBehaviour
	{
		// Token: 0x0600A2AF RID: 41647 RVA: 0x0028DCC4 File Offset: 0x0028BEC4
		// Note: this type is marked as 'beforefieldinit'.
		static ShopInterfaceDetailPanel()
		{
			Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ShopInterfaceDetailPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr);
			ShopInterfaceDetailPanel.NativeFieldInfoPtr_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, "Panel");
			ShopInterfaceDetailPanel.NativeFieldInfoPtr_LayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, "LayoutGroup");
			ShopInterfaceDetailPanel.NativeFieldInfoPtr_DescriptionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, "DescriptionLabel");
			ShopInterfaceDetailPanel.NativeFieldInfoPtr_UnlockLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, "UnlockLabel");
			ShopInterfaceDetailPanel.NativeFieldInfoPtr_listing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, "listing");
			ShopInterfaceDetailPanel.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, 100683210);
			ShopInterfaceDetailPanel.NativeMethodInfoPtr_Open_Public_Void_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, 100683211);
			ShopInterfaceDetailPanel.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, 100683212);
			ShopInterfaceDetailPanel.NativeMethodInfoPtr_Position_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, 100683213);
			ShopInterfaceDetailPanel.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, 100683214);
			ShopInterfaceDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, 100683215);
			ShopInterfaceDetailPanel.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, 100683216);
		}

		// Token: 0x0600A2B0 RID: 41648 RVA: 0x0028DDE4 File Offset: 0x0028BFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285321, XrefRangeEnd = 285324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2B1 RID: 41649 RVA: 0x0028DE18 File Offset: 0x0028C018
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285347, RefRangeEnd = 285348, XrefRangeStart = 285324, XrefRangeEnd = 285347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(ListingUI _listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.NativeMethodInfoPtr_Open_Public_Void_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2B2 RID: 41650 RVA: 0x0028DE5C File Offset: 0x0028C05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285348, XrefRangeEnd = 285349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2B3 RID: 41651 RVA: 0x0028DE90 File Offset: 0x0028C090
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285359, RefRangeEnd = 285360, XrefRangeStart = 285349, XrefRangeEnd = 285359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Position()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.NativeMethodInfoPtr_Position_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2B4 RID: 41652 RVA: 0x0028DEC4 File Offset: 0x0028C0C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285364, RefRangeEnd = 285366, XrefRangeStart = 285360, XrefRangeEnd = 285364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2B5 RID: 41653 RVA: 0x0028DEF8 File Offset: 0x0028C0F8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopInterfaceDetailPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2B6 RID: 41654 RVA: 0x0028DF34 File Offset: 0x0028C134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285366, XrefRangeEnd = 285371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A2B7 RID: 41655 RVA: 0x00050111 File Offset: 0x0004E311
		public ShopInterfaceDetailPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003228 RID: 12840
		// (get) Token: 0x0600A2B8 RID: 41656 RVA: 0x0028DF74 File Offset: 0x0028C174
		// (set) Token: 0x0600A2B9 RID: 41657 RVA: 0x0005011A File Offset: 0x0004E31A
		public unsafe RectTransform Panel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_Panel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003229 RID: 12841
		// (get) Token: 0x0600A2BA RID: 41658 RVA: 0x0028DFA4 File Offset: 0x0028C1A4
		// (set) Token: 0x0600A2BB RID: 41659 RVA: 0x00050139 File Offset: 0x0004E339
		public unsafe VerticalLayoutGroup LayoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_LayoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VerticalLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_LayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700322A RID: 12842
		// (get) Token: 0x0600A2BC RID: 41660 RVA: 0x0028DFD4 File Offset: 0x0028C1D4
		// (set) Token: 0x0600A2BD RID: 41661 RVA: 0x00050158 File Offset: 0x0004E358
		public unsafe TextMeshProUGUI DescriptionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_DescriptionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_DescriptionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700322B RID: 12843
		// (get) Token: 0x0600A2BE RID: 41662 RVA: 0x0028E004 File Offset: 0x0028C204
		// (set) Token: 0x0600A2BF RID: 41663 RVA: 0x00050177 File Offset: 0x0004E377
		public unsafe TextMeshProUGUI UnlockLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_UnlockLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_UnlockLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700322C RID: 12844
		// (get) Token: 0x0600A2C0 RID: 41664 RVA: 0x0028E034 File Offset: 0x0028C234
		// (set) Token: 0x0600A2C1 RID: 41665 RVA: 0x00050196 File Offset: 0x0004E396
		public unsafe ListingUI listing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_listing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListingUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_listing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D24 RID: 27940
		private static readonly IntPtr NativeFieldInfoPtr_Panel;

		// Token: 0x04006D25 RID: 27941
		private static readonly IntPtr NativeFieldInfoPtr_LayoutGroup;

		// Token: 0x04006D26 RID: 27942
		private static readonly IntPtr NativeFieldInfoPtr_DescriptionLabel;

		// Token: 0x04006D27 RID: 27943
		private static readonly IntPtr NativeFieldInfoPtr_UnlockLabel;

		// Token: 0x04006D28 RID: 27944
		private static readonly IntPtr NativeFieldInfoPtr_listing;

		// Token: 0x04006D29 RID: 27945
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006D2A RID: 27946
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_ListingUI_0;

		// Token: 0x04006D2B RID: 27947
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04006D2C RID: 27948
		private static readonly IntPtr NativeMethodInfoPtr_Position_Private_Void_0;

		// Token: 0x04006D2D RID: 27949
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006D2E RID: 27950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006D2F RID: 27951
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000BBC RID: 3004
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterfaceDetailPanel+<<Open>g__Wait|6_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DD73 RID: 56691 RVA: 0x00344B98 File Offset: 0x00342D98
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique()
			{
				Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, "<<Open>g__Wait|6_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr);
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, "<>1__state");
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, "<>2__current");
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, "<>4__this");
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, 100683217);
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, 100683218);
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, 100683219);
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, 100683220);
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, 100683221);
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, 100683222);
			}

			// Token: 0x0600DD74 RID: 56692 RVA: 0x00344C78 File Offset: 0x00342E78
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD75 RID: 56693 RVA: 0x00344CC0 File Offset: 0x00342EC0
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD76 RID: 56694 RVA: 0x00344CF4 File Offset: 0x00342EF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285309, XrefRangeEnd = 285316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044A1 RID: 17569
			// (get) Token: 0x0600DD77 RID: 56695 RVA: 0x00344D30 File Offset: 0x00342F30
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DD78 RID: 56696 RVA: 0x00344D70 File Offset: 0x00342F70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285316, XrefRangeEnd = 285321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044A2 RID: 17570
			// (get) Token: 0x0600DD79 RID: 56697 RVA: 0x00344DA4 File Offset: 0x00342FA4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DD7A RID: 56698 RVA: 0x0006BEAC File Offset: 0x0006A0AC
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700449E RID: 17566
			// (get) Token: 0x0600DD7B RID: 56699 RVA: 0x00344DE4 File Offset: 0x00342FE4
			// (set) Token: 0x0600DD7C RID: 56700 RVA: 0x0006BEB5 File Offset: 0x0006A0B5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700449F RID: 17567
			// (get) Token: 0x0600DD7D RID: 56701 RVA: 0x00344E0C File Offset: 0x0034300C
			// (set) Token: 0x0600DD7E RID: 56702 RVA: 0x0006BED0 File Offset: 0x0006A0D0
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044A0 RID: 17568
			// (get) Token: 0x0600DD7F RID: 56703 RVA: 0x00344E3C File Offset: 0x0034303C
			// (set) Token: 0x0600DD80 RID: 56704 RVA: 0x0006BEEF File Offset: 0x0006A0EF
			public unsafe ShopInterfaceDetailPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterfaceDetailPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009457 RID: 37975
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009458 RID: 37976
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009459 RID: 37977
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400945A RID: 37978
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400945B RID: 37979
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400945C RID: 37980
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400945D RID: 37981
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400945E RID: 37982
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400945F RID: 37983
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
