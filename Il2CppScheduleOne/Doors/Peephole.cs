using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x02000425 RID: 1061
	public class Peephole : MonoBehaviour
	{
		// Token: 0x06005D67 RID: 23911 RVA: 0x001AF398 File Offset: 0x001AD598
		// Note: this type is marked as 'beforefieldinit'.
		static Peephole()
		{
			Il2CppClassPointerStore<Peephole>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "Peephole");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Peephole>.NativeClassPtr);
			Peephole.NativeFieldInfoPtr_DoorAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Peephole>.NativeClassPtr, "DoorAnim");
			Peephole.NativeFieldInfoPtr_OpenSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Peephole>.NativeClassPtr, "OpenSound");
			Peephole.NativeFieldInfoPtr_CloseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Peephole>.NativeClassPtr, "CloseSound");
			Peephole.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Peephole>.NativeClassPtr, 100675195);
			Peephole.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Peephole>.NativeClassPtr, 100675196);
			Peephole.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Peephole>.NativeClassPtr, 100675197);
		}

		// Token: 0x06005D68 RID: 23912 RVA: 0x001AF440 File Offset: 0x001AD640
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195926, RefRangeEnd = 195927, XrefRangeStart = 195922, XrefRangeEnd = 195926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Peephole.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D69 RID: 23913 RVA: 0x001AF474 File Offset: 0x001AD674
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195931, RefRangeEnd = 195932, XrefRangeStart = 195927, XrefRangeEnd = 195931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Peephole.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D6A RID: 23914 RVA: 0x001AF4A8 File Offset: 0x001AD6A8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Peephole() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Peephole>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Peephole.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D6B RID: 23915 RVA: 0x0002C03E File Offset: 0x0002A23E
		public Peephole(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C1D RID: 7197
		// (get) Token: 0x06005D6C RID: 23916 RVA: 0x001AF4E4 File Offset: 0x001AD6E4
		// (set) Token: 0x06005D6D RID: 23917 RVA: 0x0002C047 File Offset: 0x0002A247
		public unsafe Animation DoorAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Peephole.NativeFieldInfoPtr_DoorAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Peephole.NativeFieldInfoPtr_DoorAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C1E RID: 7198
		// (get) Token: 0x06005D6E RID: 23918 RVA: 0x001AF514 File Offset: 0x001AD714
		// (set) Token: 0x06005D6F RID: 23919 RVA: 0x0002C066 File Offset: 0x0002A266
		public unsafe AudioSourceController OpenSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Peephole.NativeFieldInfoPtr_OpenSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Peephole.NativeFieldInfoPtr_OpenSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C1F RID: 7199
		// (get) Token: 0x06005D70 RID: 23920 RVA: 0x001AF544 File Offset: 0x001AD744
		// (set) Token: 0x06005D71 RID: 23921 RVA: 0x0002C085 File Offset: 0x0002A285
		public unsafe AudioSourceController CloseSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Peephole.NativeFieldInfoPtr_CloseSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Peephole.NativeFieldInfoPtr_CloseSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003FEF RID: 16367
		private static readonly IntPtr NativeFieldInfoPtr_DoorAnim;

		// Token: 0x04003FF0 RID: 16368
		private static readonly IntPtr NativeFieldInfoPtr_OpenSound;

		// Token: 0x04003FF1 RID: 16369
		private static readonly IntPtr NativeFieldInfoPtr_CloseSound;

		// Token: 0x04003FF2 RID: 16370
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04003FF3 RID: 16371
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04003FF4 RID: 16372
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
