using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Building.Doors
{
	// Token: 0x020004C4 RID: 1220
	public class DoorKnocker : MonoBehaviour
	{
		// Token: 0x06006AD1 RID: 27345 RVA: 0x001DCB8C File Offset: 0x001DAD8C
		// Note: this type is marked as 'beforefieldinit'.
		static DoorKnocker()
		{
			Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building.Doors", "DoorKnocker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr);
			DoorKnocker.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr, "Anim");
			DoorKnocker.NativeFieldInfoPtr_KnockingSoundClipName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr, "KnockingSoundClipName");
			DoorKnocker.NativeFieldInfoPtr_KnockingSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr, "KnockingSound");
			DoorKnocker.NativeMethodInfoPtr_Knock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr, 100676839);
			DoorKnocker.NativeMethodInfoPtr_PlayKnockingSound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr, 100676840);
			DoorKnocker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr, 100676841);
		}

		// Token: 0x06006AD2 RID: 27346 RVA: 0x001DCC34 File Offset: 0x001DAE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215265, XrefRangeEnd = 215269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Knock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorKnocker.NativeMethodInfoPtr_Knock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD3 RID: 27347 RVA: 0x001DCC68 File Offset: 0x001DAE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215269, XrefRangeEnd = 215271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayKnockingSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorKnocker.NativeMethodInfoPtr_PlayKnockingSound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD4 RID: 27348 RVA: 0x001DCC9C File Offset: 0x001DAE9C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoorKnocker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorKnocker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD5 RID: 27349 RVA: 0x00032806 File Offset: 0x00030A06
		public DoorKnocker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700200D RID: 8205
		// (get) Token: 0x06006AD6 RID: 27350 RVA: 0x001DCCD8 File Offset: 0x001DAED8
		// (set) Token: 0x06006AD7 RID: 27351 RVA: 0x0003280F File Offset: 0x00030A0F
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorKnocker.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorKnocker.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700200E RID: 8206
		// (get) Token: 0x06006AD8 RID: 27352 RVA: 0x001DCD08 File Offset: 0x001DAF08
		// (set) Token: 0x06006AD9 RID: 27353 RVA: 0x0003282E File Offset: 0x00030A2E
		public unsafe string KnockingSoundClipName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorKnocker.NativeFieldInfoPtr_KnockingSoundClipName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorKnocker.NativeFieldInfoPtr_KnockingSoundClipName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700200F RID: 8207
		// (get) Token: 0x06006ADA RID: 27354 RVA: 0x001DCD30 File Offset: 0x001DAF30
		// (set) Token: 0x06006ADB RID: 27355 RVA: 0x0003284D File Offset: 0x00030A4D
		public unsafe AudioSource KnockingSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorKnocker.NativeFieldInfoPtr_KnockingSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorKnocker.NativeFieldInfoPtr_KnockingSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400491B RID: 18715
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x0400491C RID: 18716
		private static readonly IntPtr NativeFieldInfoPtr_KnockingSoundClipName;

		// Token: 0x0400491D RID: 18717
		private static readonly IntPtr NativeFieldInfoPtr_KnockingSound;

		// Token: 0x0400491E RID: 18718
		private static readonly IntPtr NativeMethodInfoPtr_Knock_Public_Void_0;

		// Token: 0x0400491F RID: 18719
		private static readonly IntPtr NativeMethodInfoPtr_PlayKnockingSound_Public_Void_0;

		// Token: 0x04004920 RID: 18720
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
