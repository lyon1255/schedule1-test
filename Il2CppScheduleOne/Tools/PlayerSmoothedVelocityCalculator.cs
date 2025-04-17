using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000547 RID: 1351
	public class PlayerSmoothedVelocityCalculator : SmoothedVelocityCalculator
	{
		// Token: 0x06007788 RID: 30600 RVA: 0x002066A0 File Offset: 0x002048A0
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerSmoothedVelocityCalculator()
		{
			Il2CppClassPointerStore<PlayerSmoothedVelocityCalculator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "PlayerSmoothedVelocityCalculator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSmoothedVelocityCalculator>.NativeClassPtr);
			PlayerSmoothedVelocityCalculator.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSmoothedVelocityCalculator>.NativeClassPtr, "Player");
			PlayerSmoothedVelocityCalculator.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSmoothedVelocityCalculator>.NativeClassPtr, 100678350);
			PlayerSmoothedVelocityCalculator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSmoothedVelocityCalculator>.NativeClassPtr, 100678351);
		}

		// Token: 0x06007789 RID: 30601 RVA: 0x0020670C File Offset: 0x0020490C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231792, XrefRangeEnd = 231802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerSmoothedVelocityCalculator.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600778A RID: 30602 RVA: 0x00206748 File Offset: 0x00204948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231802, XrefRangeEnd = 231814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerSmoothedVelocityCalculator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSmoothedVelocityCalculator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSmoothedVelocityCalculator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600778B RID: 30603 RVA: 0x000389AA File Offset: 0x00036BAA
		public PlayerSmoothedVelocityCalculator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002421 RID: 9249
		// (get) Token: 0x0600778C RID: 30604 RVA: 0x00206784 File Offset: 0x00204984
		// (set) Token: 0x0600778D RID: 30605 RVA: 0x000389B3 File Offset: 0x00036BB3
		public unsafe Player Player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSmoothedVelocityCalculator.NativeFieldInfoPtr_Player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSmoothedVelocityCalculator.NativeFieldInfoPtr_Player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005192 RID: 20882
		private static readonly IntPtr NativeFieldInfoPtr_Player;

		// Token: 0x04005193 RID: 20883
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_0;

		// Token: 0x04005194 RID: 20884
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
