using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Handover
{
	// Token: 0x020006F4 RID: 1780
	public class HandoverScreenPriceSelector : MonoBehaviour
	{
		// Token: 0x06009F7B RID: 40827 RVA: 0x002836FC File Offset: 0x002818FC
		// Note: this type is marked as 'beforefieldinit'.
		static HandoverScreenPriceSelector()
		{
			Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Handover", "HandoverScreenPriceSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr);
			HandoverScreenPriceSelector.NativeFieldInfoPtr_MinPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, "MinPrice");
			HandoverScreenPriceSelector.NativeFieldInfoPtr_MaxPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, "MaxPrice");
			HandoverScreenPriceSelector.NativeFieldInfoPtr_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, "InputField");
			HandoverScreenPriceSelector.NativeFieldInfoPtr__Price_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, "<Price>k__BackingField");
			HandoverScreenPriceSelector.NativeFieldInfoPtr_onPriceChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, "onPriceChanged");
			HandoverScreenPriceSelector.NativeMethodInfoPtr_get_Price_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, 100682818);
			HandoverScreenPriceSelector.NativeMethodInfoPtr_set_Price_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, 100682819);
			HandoverScreenPriceSelector.NativeMethodInfoPtr_SetPrice_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, 100682820);
			HandoverScreenPriceSelector.NativeMethodInfoPtr_RefreshPrice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, 100682821);
			HandoverScreenPriceSelector.NativeMethodInfoPtr_OnPriceInputChanged_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, 100682822);
			HandoverScreenPriceSelector.NativeMethodInfoPtr_ChangeAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, 100682823);
			HandoverScreenPriceSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr, 100682824);
		}

		// Token: 0x17003126 RID: 12582
		// (get) Token: 0x06009F7C RID: 40828 RVA: 0x0028381C File Offset: 0x00281A1C
		// (set) Token: 0x06009F7D RID: 40829 RVA: 0x00283858 File Offset: 0x00281A58
		public unsafe float Price
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59847, RefRangeEnd = 59848, XrefRangeStart = 59847, XrefRangeEnd = 59848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenPriceSelector.NativeMethodInfoPtr_get_Price_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenPriceSelector.NativeMethodInfoPtr_set_Price_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009F7E RID: 40830 RVA: 0x00283898 File Offset: 0x00281A98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281319, RefRangeEnd = 281321, XrefRangeStart = 281316, XrefRangeEnd = 281319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPrice(float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenPriceSelector.NativeMethodInfoPtr_SetPrice_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F7F RID: 40831 RVA: 0x002838D8 File Offset: 0x00281AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281321, XrefRangeEnd = 281324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPrice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenPriceSelector.NativeMethodInfoPtr_RefreshPrice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F80 RID: 40832 RVA: 0x0028390C File Offset: 0x00281B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281324, XrefRangeEnd = 281327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPriceInputChanged(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenPriceSelector.NativeMethodInfoPtr_OnPriceInputChanged_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F81 RID: 40833 RVA: 0x00283950 File Offset: 0x00281B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281327, XrefRangeEnd = 281328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeAmount(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenPriceSelector.NativeMethodInfoPtr_ChangeAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F82 RID: 40834 RVA: 0x00283990 File Offset: 0x00281B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HandoverScreenPriceSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandoverScreenPriceSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreenPriceSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F83 RID: 40835 RVA: 0x0004E5A1 File Offset: 0x0004C7A1
		public HandoverScreenPriceSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003121 RID: 12577
		// (get) Token: 0x06009F84 RID: 40836 RVA: 0x002839CC File Offset: 0x00281BCC
		// (set) Token: 0x06009F85 RID: 40837 RVA: 0x0004E5AA File Offset: 0x0004C7AA
		public unsafe static float MinPrice
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(HandoverScreenPriceSelector.NativeFieldInfoPtr_MinPrice, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HandoverScreenPriceSelector.NativeFieldInfoPtr_MinPrice, (void*)(&value));
			}
		}

		// Token: 0x17003122 RID: 12578
		// (get) Token: 0x06009F86 RID: 40838 RVA: 0x002839E8 File Offset: 0x00281BE8
		// (set) Token: 0x06009F87 RID: 40839 RVA: 0x0004E5B8 File Offset: 0x0004C7B8
		public unsafe static float MaxPrice
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(HandoverScreenPriceSelector.NativeFieldInfoPtr_MaxPrice, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HandoverScreenPriceSelector.NativeFieldInfoPtr_MaxPrice, (void*)(&value));
			}
		}

		// Token: 0x17003123 RID: 12579
		// (get) Token: 0x06009F88 RID: 40840 RVA: 0x00283A04 File Offset: 0x00281C04
		// (set) Token: 0x06009F89 RID: 40841 RVA: 0x0004E5C6 File Offset: 0x0004C7C6
		public unsafe InputField InputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenPriceSelector.NativeFieldInfoPtr_InputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenPriceSelector.NativeFieldInfoPtr_InputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003124 RID: 12580
		// (get) Token: 0x06009F8A RID: 40842 RVA: 0x00283A34 File Offset: 0x00281C34
		// (set) Token: 0x06009F8B RID: 40843 RVA: 0x0004E5E5 File Offset: 0x0004C7E5
		public unsafe float _Price_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenPriceSelector.NativeFieldInfoPtr__Price_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenPriceSelector.NativeFieldInfoPtr__Price_k__BackingField)) = value;
			}
		}

		// Token: 0x17003125 RID: 12581
		// (get) Token: 0x06009F8C RID: 40844 RVA: 0x00283A5C File Offset: 0x00281C5C
		// (set) Token: 0x06009F8D RID: 40845 RVA: 0x0004E600 File Offset: 0x0004C800
		public unsafe UnityEvent onPriceChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenPriceSelector.NativeFieldInfoPtr_onPriceChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreenPriceSelector.NativeFieldInfoPtr_onPriceChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006AF7 RID: 27383
		private static readonly IntPtr NativeFieldInfoPtr_MinPrice;

		// Token: 0x04006AF8 RID: 27384
		private static readonly IntPtr NativeFieldInfoPtr_MaxPrice;

		// Token: 0x04006AF9 RID: 27385
		private static readonly IntPtr NativeFieldInfoPtr_InputField;

		// Token: 0x04006AFA RID: 27386
		private static readonly IntPtr NativeFieldInfoPtr__Price_k__BackingField;

		// Token: 0x04006AFB RID: 27387
		private static readonly IntPtr NativeFieldInfoPtr_onPriceChanged;

		// Token: 0x04006AFC RID: 27388
		private static readonly IntPtr NativeMethodInfoPtr_get_Price_Public_get_Single_0;

		// Token: 0x04006AFD RID: 27389
		private static readonly IntPtr NativeMethodInfoPtr_set_Price_Private_set_Void_Single_0;

		// Token: 0x04006AFE RID: 27390
		private static readonly IntPtr NativeMethodInfoPtr_SetPrice_Public_Void_Single_0;

		// Token: 0x04006AFF RID: 27391
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPrice_Public_Void_0;

		// Token: 0x04006B00 RID: 27392
		private static readonly IntPtr NativeMethodInfoPtr_OnPriceInputChanged_Public_Void_String_0;

		// Token: 0x04006B01 RID: 27393
		private static readonly IntPtr NativeMethodInfoPtr_ChangeAmount_Public_Void_Single_0;

		// Token: 0x04006B02 RID: 27394
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
