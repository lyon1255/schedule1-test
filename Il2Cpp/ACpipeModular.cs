using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200002B RID: 43
	public class ACpipeModular : MonoBehaviour
	{
		// Token: 0x0600031E RID: 798 RVA: 0x0007A0FC File Offset: 0x000782FC
		// Note: this type is marked as 'beforefieldinit'.
		static ACpipeModular()
		{
			Il2CppClassPointerStore<ACpipeModular>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ACpipeModular");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACpipeModular>.NativeClassPtr);
			ACpipeModular.NativeFieldInfoPtr_itemsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACpipeModular>.NativeClassPtr, "itemsList");
			ACpipeModular.NativeFieldInfoPtr_largeACPipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACpipeModular>.NativeClassPtr, "largeACPipe");
			ACpipeModular.NativeFieldInfoPtr_smallACpipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACpipeModular>.NativeClassPtr, "smallACpipe");
			ACpipeModular.NativeFieldInfoPtr_innerCorner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACpipeModular>.NativeClassPtr, "innerCorner");
			ACpipeModular.NativeFieldInfoPtr_outerCorner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACpipeModular>.NativeClassPtr, "outerCorner");
			ACpipeModular.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACpipeModular>.NativeClassPtr, 100663595);
			ACpipeModular.NativeMethodInfoPtr_BuildNextItem_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACpipeModular>.NativeClassPtr, 100663596);
			ACpipeModular.NativeMethodInfoPtr_DeleteLastItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACpipeModular>.NativeClassPtr, 100663597);
			ACpipeModular.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACpipeModular>.NativeClassPtr, 100663598);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0007A1E0 File Offset: 0x000783E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73142, XrefRangeEnd = 73171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACpipeModular.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0007A214 File Offset: 0x00078414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73171, XrefRangeEnd = 73207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildNextItem(GameObject item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACpipeModular.NativeMethodInfoPtr_BuildNextItem_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0007A258 File Offset: 0x00078458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73207, XrefRangeEnd = 73228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteLastItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACpipeModular.NativeMethodInfoPtr_DeleteLastItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0007A28C File Offset: 0x0007848C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73228, XrefRangeEnd = 73236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACpipeModular() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACpipeModular>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACpipeModular.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00003BDE File Offset: 0x00001DDE
		public ACpipeModular(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000324 RID: 804 RVA: 0x0007A2C8 File Offset: 0x000784C8
		// (set) Token: 0x06000325 RID: 805 RVA: 0x00003BE7 File Offset: 0x00001DE7
		public unsafe List<GameObject> itemsList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACpipeModular.NativeFieldInfoPtr_itemsList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACpipeModular.NativeFieldInfoPtr_itemsList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0007A2F8 File Offset: 0x000784F8
		// (set) Token: 0x06000327 RID: 807 RVA: 0x00003C06 File Offset: 0x00001E06
		public unsafe GameObject largeACPipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACpipeModular.NativeFieldInfoPtr_largeACPipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACpipeModular.NativeFieldInfoPtr_largeACPipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000328 RID: 808 RVA: 0x0007A328 File Offset: 0x00078528
		// (set) Token: 0x06000329 RID: 809 RVA: 0x00003C25 File Offset: 0x00001E25
		public unsafe GameObject smallACpipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACpipeModular.NativeFieldInfoPtr_smallACpipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACpipeModular.NativeFieldInfoPtr_smallACpipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0007A358 File Offset: 0x00078558
		// (set) Token: 0x0600032B RID: 811 RVA: 0x00003C44 File Offset: 0x00001E44
		public unsafe GameObject innerCorner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACpipeModular.NativeFieldInfoPtr_innerCorner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACpipeModular.NativeFieldInfoPtr_innerCorner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0007A388 File Offset: 0x00078588
		// (set) Token: 0x0600032D RID: 813 RVA: 0x00003C63 File Offset: 0x00001E63
		public unsafe GameObject outerCorner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACpipeModular.NativeFieldInfoPtr_outerCorner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACpipeModular.NativeFieldInfoPtr_outerCorner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeFieldInfoPtr_itemsList;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeFieldInfoPtr_largeACPipe;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeFieldInfoPtr_smallACpipe;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeFieldInfoPtr_innerCorner;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeFieldInfoPtr_outerCorner;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_BuildNextItem_Public_Void_GameObject_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_DeleteLastItem_Public_Void_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
