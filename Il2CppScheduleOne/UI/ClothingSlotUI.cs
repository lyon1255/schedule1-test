using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000643 RID: 1603
	public class ClothingSlotUI : ItemSlotUI
	{
		// Token: 0x06008DF6 RID: 36342 RVA: 0x0024F0FC File Offset: 0x0024D2FC
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingSlotUI()
		{
			Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ClothingSlotUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr);
			ClothingSlotUI.NativeFieldInfoPtr_SlotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr, "SlotType");
			ClothingSlotUI.NativeFieldInfoPtr_SlotTypeImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr, "SlotTypeImage");
			ClothingSlotUI.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr, 100680926);
			ClothingSlotUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr, 100680927);
		}

		// Token: 0x06008DF7 RID: 36343 RVA: 0x0024F17C File Offset: 0x0024D37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258284, XrefRangeEnd = 258291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingSlotUI.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DF8 RID: 36344 RVA: 0x0024F1B0 File Offset: 0x0024D3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingSlotUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingSlotUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingSlotUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DF9 RID: 36345 RVA: 0x000443D1 File Offset: 0x000425D1
		public ClothingSlotUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B5C RID: 11100
		// (get) Token: 0x06008DFA RID: 36346 RVA: 0x0024F1EC File Offset: 0x0024D3EC
		// (set) Token: 0x06008DFB RID: 36347 RVA: 0x000443DA File Offset: 0x000425DA
		public unsafe EClothingSlot SlotType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingSlotUI.NativeFieldInfoPtr_SlotType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingSlotUI.NativeFieldInfoPtr_SlotType)) = value;
			}
		}

		// Token: 0x17002B5D RID: 11101
		// (get) Token: 0x06008DFC RID: 36348 RVA: 0x0024F214 File Offset: 0x0024D414
		// (set) Token: 0x06008DFD RID: 36349 RVA: 0x000443F5 File Offset: 0x000425F5
		public unsafe Image SlotTypeImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingSlotUI.NativeFieldInfoPtr_SlotTypeImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingSlotUI.NativeFieldInfoPtr_SlotTypeImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006020 RID: 24608
		private static readonly IntPtr NativeFieldInfoPtr_SlotType;

		// Token: 0x04006021 RID: 24609
		private static readonly IntPtr NativeFieldInfoPtr_SlotTypeImage;

		// Token: 0x04006022 RID: 24610
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04006023 RID: 24611
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
