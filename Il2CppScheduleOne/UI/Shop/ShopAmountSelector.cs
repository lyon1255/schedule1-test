using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x0200070C RID: 1804
	public class ShopAmountSelector : MonoBehaviour
	{
		// Token: 0x0600A20D RID: 41485 RVA: 0x0028BB0C File Offset: 0x00289D0C
		// Note: this type is marked as 'beforefieldinit'.
		static ShopAmountSelector()
		{
			Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ShopAmountSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr);
			ShopAmountSelector.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, "<IsOpen>k__BackingField");
			ShopAmountSelector.NativeFieldInfoPtr__SelectedAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, "<SelectedAmount>k__BackingField");
			ShopAmountSelector.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, "Container");
			ShopAmountSelector.NativeFieldInfoPtr_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, "InputField");
			ShopAmountSelector.NativeFieldInfoPtr_onSubmitted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, "onSubmitted");
			ShopAmountSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683115);
			ShopAmountSelector.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683116);
			ShopAmountSelector.NativeMethodInfoPtr_get_SelectedAmount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683117);
			ShopAmountSelector.NativeMethodInfoPtr_set_SelectedAmount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683118);
			ShopAmountSelector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683119);
			ShopAmountSelector.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683120);
			ShopAmountSelector.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683121);
			ShopAmountSelector.NativeMethodInfoPtr_OnSubmitted_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683122);
			ShopAmountSelector.NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683123);
			ShopAmountSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100683124);
		}

		// Token: 0x170031F6 RID: 12790
		// (get) Token: 0x0600A20E RID: 41486 RVA: 0x0028BC68 File Offset: 0x00289E68
		// (set) Token: 0x0600A20F RID: 41487 RVA: 0x0028BCA4 File Offset: 0x00289EA4
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170031F7 RID: 12791
		// (get) Token: 0x0600A210 RID: 41488 RVA: 0x0028BCE4 File Offset: 0x00289EE4
		// (set) Token: 0x0600A211 RID: 41489 RVA: 0x0028BD20 File Offset: 0x00289F20
		public unsafe int SelectedAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_get_SelectedAmount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29962, RefRangeEnd = 29963, XrefRangeStart = 29962, XrefRangeEnd = 29963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_set_SelectedAmount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A212 RID: 41490 RVA: 0x0028BD60 File Offset: 0x00289F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284163, XrefRangeEnd = 284182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A213 RID: 41491 RVA: 0x0028BD94 File Offset: 0x00289F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284182, XrefRangeEnd = 284188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A214 RID: 41492 RVA: 0x0028BDC8 File Offset: 0x00289FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284188, XrefRangeEnd = 284190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A215 RID: 41493 RVA: 0x0028BDFC File Offset: 0x00289FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284190, XrefRangeEnd = 284202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSubmitted(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_OnSubmitted_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A216 RID: 41494 RVA: 0x0028BE40 File Offset: 0x0028A040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284202, XrefRangeEnd = 284206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChanged(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A217 RID: 41495 RVA: 0x0028BE84 File Offset: 0x0028A084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284206, XrefRangeEnd = 284207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopAmountSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A218 RID: 41496 RVA: 0x0004FBE0 File Offset: 0x0004DDE0
		public ShopAmountSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031F1 RID: 12785
		// (get) Token: 0x0600A219 RID: 41497 RVA: 0x0028BEC0 File Offset: 0x0028A0C0
		// (set) Token: 0x0600A21A RID: 41498 RVA: 0x0004FBE9 File Offset: 0x0004DDE9
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170031F2 RID: 12786
		// (get) Token: 0x0600A21B RID: 41499 RVA: 0x0028BEE8 File Offset: 0x0028A0E8
		// (set) Token: 0x0600A21C RID: 41500 RVA: 0x0004FC04 File Offset: 0x0004DE04
		public unsafe int _SelectedAmount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr__SelectedAmount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr__SelectedAmount_k__BackingField)) = value;
			}
		}

		// Token: 0x170031F3 RID: 12787
		// (get) Token: 0x0600A21D RID: 41501 RVA: 0x0028BF10 File Offset: 0x0028A110
		// (set) Token: 0x0600A21E RID: 41502 RVA: 0x0004FC1F File Offset: 0x0004DE1F
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031F4 RID: 12788
		// (get) Token: 0x0600A21F RID: 41503 RVA: 0x0028BF40 File Offset: 0x0028A140
		// (set) Token: 0x0600A220 RID: 41504 RVA: 0x0004FC3E File Offset: 0x0004DE3E
		public unsafe TMP_InputField InputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr_InputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr_InputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031F5 RID: 12789
		// (get) Token: 0x0600A221 RID: 41505 RVA: 0x0028BF70 File Offset: 0x0028A170
		// (set) Token: 0x0600A222 RID: 41506 RVA: 0x0004FC5D File Offset: 0x0004DE5D
		public unsafe UnityEvent<int> onSubmitted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr_onSubmitted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr_onSubmitted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006CB4 RID: 27828
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006CB5 RID: 27829
		private static readonly IntPtr NativeFieldInfoPtr__SelectedAmount_k__BackingField;

		// Token: 0x04006CB6 RID: 27830
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006CB7 RID: 27831
		private static readonly IntPtr NativeFieldInfoPtr_InputField;

		// Token: 0x04006CB8 RID: 27832
		private static readonly IntPtr NativeFieldInfoPtr_onSubmitted;

		// Token: 0x04006CB9 RID: 27833
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006CBA RID: 27834
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04006CBB RID: 27835
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedAmount_Public_get_Int32_0;

		// Token: 0x04006CBC RID: 27836
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedAmount_Private_set_Void_Int32_0;

		// Token: 0x04006CBD RID: 27837
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006CBE RID: 27838
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04006CBF RID: 27839
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006CC0 RID: 27840
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmitted_Private_Void_String_0;

		// Token: 0x04006CC1 RID: 27841
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0;

		// Token: 0x04006CC2 RID: 27842
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
