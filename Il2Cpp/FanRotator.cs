using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000026 RID: 38
	public class FanRotator : MonoBehaviour
	{
		// Token: 0x060002C7 RID: 711 RVA: 0x00079110 File Offset: 0x00077310
		// Note: this type is marked as 'beforefieldinit'.
		static FanRotator()
		{
			Il2CppClassPointerStore<FanRotator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FanRotator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FanRotator>.NativeClassPtr);
			FanRotator.NativeFieldInfoPtr_thisTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FanRotator>.NativeClassPtr, "thisTransform");
			FanRotator.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FanRotator>.NativeClassPtr, "speed");
			FanRotator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FanRotator>.NativeClassPtr, 100663557);
			FanRotator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FanRotator>.NativeClassPtr, 100663558);
			FanRotator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FanRotator>.NativeClassPtr, 100663559);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x000791A4 File Offset: 0x000773A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72767, XrefRangeEnd = 72771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FanRotator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x000791D8 File Offset: 0x000773D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72771, XrefRangeEnd = 72773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FanRotator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0007920C File Offset: 0x0007740C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72773, XrefRangeEnd = 72774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FanRotator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FanRotator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FanRotator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00003918 File Offset: 0x00001B18
		public FanRotator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00079248 File Offset: 0x00077448
		// (set) Token: 0x060002CD RID: 717 RVA: 0x00003921 File Offset: 0x00001B21
		public unsafe Transform thisTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FanRotator.NativeFieldInfoPtr_thisTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FanRotator.NativeFieldInfoPtr_thisTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002CE RID: 718 RVA: 0x00079278 File Offset: 0x00077478
		// (set) Token: 0x060002CF RID: 719 RVA: 0x00003940 File Offset: 0x00001B40
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FanRotator.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FanRotator.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeFieldInfoPtr_thisTransform;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
