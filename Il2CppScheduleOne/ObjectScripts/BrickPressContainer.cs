using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Packaging;
using Il2CppScheduleOne.Product;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000739 RID: 1849
	public class BrickPressContainer : MonoBehaviour
	{
		// Token: 0x0600A9C5 RID: 43461 RVA: 0x002A6894 File Offset: 0x002A4A94
		// Note: this type is marked as 'beforefieldinit'.
		static BrickPressContainer()
		{
			Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "BrickPressContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr);
			BrickPressContainer.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr, "Visuals");
			BrickPressContainer.NativeFieldInfoPtr_ContentsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr, "ContentsContainer");
			BrickPressContainer.NativeFieldInfoPtr_Contents_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr, "Contents_Min");
			BrickPressContainer.NativeFieldInfoPtr_Contents_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr, "Contents_Max");
			BrickPressContainer.NativeMethodInfoPtr_SetContents_Public_Void_ProductItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr, 100684130);
			BrickPressContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr, 100684131);
		}

		// Token: 0x0600A9C6 RID: 43462 RVA: 0x002A693C File Offset: 0x002A4B3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295085, RefRangeEnd = 295087, XrefRangeStart = 295075, XrefRangeEnd = 295085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContents(ProductItemInstance product, float fillLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fillLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressContainer.NativeMethodInfoPtr_SetContents_Public_Void_ProductItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9C7 RID: 43463 RVA: 0x002A698C File Offset: 0x002A4B8C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPressContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9C8 RID: 43464 RVA: 0x0005386B File Offset: 0x00051A6B
		public BrickPressContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003476 RID: 13430
		// (get) Token: 0x0600A9C9 RID: 43465 RVA: 0x002A69C8 File Offset: 0x002A4BC8
		// (set) Token: 0x0600A9CA RID: 43466 RVA: 0x00053874 File Offset: 0x00051A74
		public unsafe FilledPackagingVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003477 RID: 13431
		// (get) Token: 0x0600A9CB RID: 43467 RVA: 0x002A69F8 File Offset: 0x002A4BF8
		// (set) Token: 0x0600A9CC RID: 43468 RVA: 0x00053893 File Offset: 0x00051A93
		public unsafe Transform ContentsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_ContentsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_ContentsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003478 RID: 13432
		// (get) Token: 0x0600A9CD RID: 43469 RVA: 0x002A6A28 File Offset: 0x002A4C28
		// (set) Token: 0x0600A9CE RID: 43470 RVA: 0x000538B2 File Offset: 0x00051AB2
		public unsafe Transform Contents_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_Contents_Min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_Contents_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003479 RID: 13433
		// (get) Token: 0x0600A9CF RID: 43471 RVA: 0x002A6A58 File Offset: 0x002A4C58
		// (set) Token: 0x0600A9D0 RID: 43472 RVA: 0x000538D1 File Offset: 0x00051AD1
		public unsafe Transform Contents_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_Contents_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_Contents_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007205 RID: 29189
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x04007206 RID: 29190
		private static readonly IntPtr NativeFieldInfoPtr_ContentsContainer;

		// Token: 0x04007207 RID: 29191
		private static readonly IntPtr NativeFieldInfoPtr_Contents_Min;

		// Token: 0x04007208 RID: 29192
		private static readonly IntPtr NativeFieldInfoPtr_Contents_Max;

		// Token: 0x04007209 RID: 29193
		private static readonly IntPtr NativeMethodInfoPtr_SetContents_Public_Void_ProductItemInstance_Single_0;

		// Token: 0x0400720A RID: 29194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
