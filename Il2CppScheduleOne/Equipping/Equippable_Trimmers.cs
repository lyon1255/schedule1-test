using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005BB RID: 1467
	public class Equippable_Trimmers : Equippable_Viewmodel
	{
		// Token: 0x060080C6 RID: 32966 RVA: 0x00226460 File Offset: 0x00224660
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Trimmers()
		{
			Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Trimmers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr);
			Equippable_Trimmers.NativeFieldInfoPtr_CanClickAndDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr, "CanClickAndDrag");
			Equippable_Trimmers.NativeFieldInfoPtr_SoundLoopPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr, "SoundLoopPrefab");
			Equippable_Trimmers.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr, 100679445);
			Equippable_Trimmers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr, 100679446);
		}

		// Token: 0x060080C7 RID: 32967 RVA: 0x002264E0 File Offset: 0x002246E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244502, XrefRangeEnd = 244532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Trimmers.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080C8 RID: 32968 RVA: 0x0022651C File Offset: 0x0022471C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 244274, RefRangeEnd = 244282, XrefRangeStart = 244274, XrefRangeEnd = 244282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Trimmers() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Trimmers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080C9 RID: 32969 RVA: 0x0003D1E5 File Offset: 0x0003B3E5
		public Equippable_Trimmers(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026EB RID: 9963
		// (get) Token: 0x060080CA RID: 32970 RVA: 0x00226558 File Offset: 0x00224758
		// (set) Token: 0x060080CB RID: 32971 RVA: 0x0003D1EE File Offset: 0x0003B3EE
		public unsafe bool CanClickAndDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Trimmers.NativeFieldInfoPtr_CanClickAndDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Trimmers.NativeFieldInfoPtr_CanClickAndDrag)) = value;
			}
		}

		// Token: 0x170026EC RID: 9964
		// (get) Token: 0x060080CC RID: 32972 RVA: 0x00226580 File Offset: 0x00224780
		// (set) Token: 0x060080CD RID: 32973 RVA: 0x0003D209 File Offset: 0x0003B409
		public unsafe AudioSourceController SoundLoopPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Trimmers.NativeFieldInfoPtr_SoundLoopPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Trimmers.NativeFieldInfoPtr_SoundLoopPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040057B1 RID: 22449
		private static readonly IntPtr NativeFieldInfoPtr_CanClickAndDrag;

		// Token: 0x040057B2 RID: 22450
		private static readonly IntPtr NativeFieldInfoPtr_SoundLoopPrefab;

		// Token: 0x040057B3 RID: 22451
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040057B4 RID: 22452
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
