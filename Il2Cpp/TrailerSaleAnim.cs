using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200001E RID: 30
	public class TrailerSaleAnim : MonoBehaviour
	{
		// Token: 0x060001D5 RID: 469 RVA: 0x00076440 File Offset: 0x00074640
		// Note: this type is marked as 'beforefieldinit'.
		static TrailerSaleAnim()
		{
			Il2CppClassPointerStore<TrailerSaleAnim>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TrailerSaleAnim");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrailerSaleAnim>.NativeClassPtr);
			TrailerSaleAnim.NativeFieldInfoPtr_NPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerSaleAnim>.NativeClassPtr, "NPCs");
			TrailerSaleAnim.NativeMethodInfoPtr_PlayAnim_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerSaleAnim>.NativeClassPtr, 100663469);
			TrailerSaleAnim.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerSaleAnim>.NativeClassPtr, 100663470);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000764AC File Offset: 0x000746AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72284, XrefRangeEnd = 72294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayAnim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerSaleAnim.NativeMethodInfoPtr_PlayAnim_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000764E0 File Offset: 0x000746E0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrailerSaleAnim() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrailerSaleAnim>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerSaleAnim.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000302A File Offset: 0x0000122A
		public TrailerSaleAnim(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0007651C File Offset: 0x0007471C
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00003033 File Offset: 0x00001233
		public unsafe Il2CppReferenceArray<NPC> NPCs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerSaleAnim.NativeFieldInfoPtr_NPCs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerSaleAnim.NativeFieldInfoPtr_NPCs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeFieldInfoPtr_NPCs;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_PlayAnim_Public_Void_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
