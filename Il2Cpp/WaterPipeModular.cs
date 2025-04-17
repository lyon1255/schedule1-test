using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000032 RID: 50
	public class WaterPipeModular : MonoBehaviour
	{
		// Token: 0x0600037C RID: 892 RVA: 0x0007B29C File Offset: 0x0007949C
		// Note: this type is marked as 'beforefieldinit'.
		static WaterPipeModular()
		{
			Il2CppClassPointerStore<WaterPipeModular>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WaterPipeModular");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaterPipeModular>.NativeClassPtr);
			WaterPipeModular.NativeFieldInfoPtr_itemsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterPipeModular>.NativeClassPtr, "itemsList");
			WaterPipeModular.NativeFieldInfoPtr_largeWaterPipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterPipeModular>.NativeClassPtr, "largeWaterPipe");
			WaterPipeModular.NativeFieldInfoPtr_mediumWaterPipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterPipeModular>.NativeClassPtr, "mediumWaterPipe");
			WaterPipeModular.NativeFieldInfoPtr_smallWaterpipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterPipeModular>.NativeClassPtr, "smallWaterpipe");
			WaterPipeModular.NativeFieldInfoPtr_innerCorner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterPipeModular>.NativeClassPtr, "innerCorner");
			WaterPipeModular.NativeFieldInfoPtr_outerCorner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterPipeModular>.NativeClassPtr, "outerCorner");
			WaterPipeModular.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterPipeModular>.NativeClassPtr, 100663633);
			WaterPipeModular.NativeMethodInfoPtr_BuildNextItem_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterPipeModular>.NativeClassPtr, 100663634);
			WaterPipeModular.NativeMethodInfoPtr_DeleteLastItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterPipeModular>.NativeClassPtr, 100663635);
			WaterPipeModular.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterPipeModular>.NativeClassPtr, 100663636);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0007B394 File Offset: 0x00079594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73587, XrefRangeEnd = 73623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterPipeModular.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0007B3C8 File Offset: 0x000795C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73623, XrefRangeEnd = 73653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildNextItem(GameObject item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterPipeModular.NativeMethodInfoPtr_BuildNextItem_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0007B40C File Offset: 0x0007960C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73653, XrefRangeEnd = 73674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteLastItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterPipeModular.NativeMethodInfoPtr_DeleteLastItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0007B440 File Offset: 0x00079640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73674, XrefRangeEnd = 73687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaterPipeModular() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaterPipeModular>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterPipeModular.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00003F8B File Offset: 0x0000218B
		public WaterPipeModular(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000382 RID: 898 RVA: 0x0007B47C File Offset: 0x0007967C
		// (set) Token: 0x06000383 RID: 899 RVA: 0x00003F94 File Offset: 0x00002194
		public unsafe List<GameObject> itemsList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterPipeModular.NativeFieldInfoPtr_itemsList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterPipeModular.NativeFieldInfoPtr_itemsList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0007B4AC File Offset: 0x000796AC
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00003FB3 File Offset: 0x000021B3
		public unsafe GameObject largeWaterPipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterPipeModular.NativeFieldInfoPtr_largeWaterPipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterPipeModular.NativeFieldInfoPtr_largeWaterPipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0007B4DC File Offset: 0x000796DC
		// (set) Token: 0x06000387 RID: 903 RVA: 0x00003FD2 File Offset: 0x000021D2
		public unsafe GameObject mediumWaterPipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterPipeModular.NativeFieldInfoPtr_mediumWaterPipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterPipeModular.NativeFieldInfoPtr_mediumWaterPipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000388 RID: 904 RVA: 0x0007B50C File Offset: 0x0007970C
		// (set) Token: 0x06000389 RID: 905 RVA: 0x00003FF1 File Offset: 0x000021F1
		public unsafe GameObject smallWaterpipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterPipeModular.NativeFieldInfoPtr_smallWaterpipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterPipeModular.NativeFieldInfoPtr_smallWaterpipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600038A RID: 906 RVA: 0x0007B53C File Offset: 0x0007973C
		// (set) Token: 0x0600038B RID: 907 RVA: 0x00004010 File Offset: 0x00002210
		public unsafe GameObject innerCorner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterPipeModular.NativeFieldInfoPtr_innerCorner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterPipeModular.NativeFieldInfoPtr_innerCorner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600038C RID: 908 RVA: 0x0007B56C File Offset: 0x0007976C
		// (set) Token: 0x0600038D RID: 909 RVA: 0x0000402F File Offset: 0x0000222F
		public unsafe GameObject outerCorner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterPipeModular.NativeFieldInfoPtr_outerCorner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterPipeModular.NativeFieldInfoPtr_outerCorner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeFieldInfoPtr_itemsList;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeFieldInfoPtr_largeWaterPipe;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeFieldInfoPtr_mediumWaterPipe;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeFieldInfoPtr_smallWaterpipe;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeFieldInfoPtr_innerCorner;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeFieldInfoPtr_outerCorner;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_BuildNextItem_Public_Void_GameObject_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_DeleteLastItem_Public_Void_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
