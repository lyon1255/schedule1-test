using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000540 RID: 1344
	public class NPCWalkTo : MonoBehaviour
	{
		// Token: 0x06007724 RID: 30500 RVA: 0x002053D4 File Offset: 0x002035D4
		// Note: this type is marked as 'beforefieldinit'.
		static NPCWalkTo()
		{
			Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "NPCWalkTo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr);
			NPCWalkTo.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr, "Target");
			NPCWalkTo.NativeFieldInfoPtr_RepathRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr, "RepathRate");
			NPCWalkTo.NativeFieldInfoPtr_timeSinceLastPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr, "timeSinceLastPath");
			NPCWalkTo.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr, 100678312);
			NPCWalkTo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr, 100678313);
		}

		// Token: 0x06007725 RID: 30501 RVA: 0x00205468 File Offset: 0x00203668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231376, XrefRangeEnd = 231382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCWalkTo.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007726 RID: 30502 RVA: 0x0020549C File Offset: 0x0020369C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCWalkTo() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCWalkTo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007727 RID: 30503 RVA: 0x000386DA File Offset: 0x000368DA
		public NPCWalkTo(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002408 RID: 9224
		// (get) Token: 0x06007728 RID: 30504 RVA: 0x002054D8 File Offset: 0x002036D8
		// (set) Token: 0x06007729 RID: 30505 RVA: 0x000386E3 File Offset: 0x000368E3
		public unsafe Transform Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCWalkTo.NativeFieldInfoPtr_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCWalkTo.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002409 RID: 9225
		// (get) Token: 0x0600772A RID: 30506 RVA: 0x00205508 File Offset: 0x00203708
		// (set) Token: 0x0600772B RID: 30507 RVA: 0x00038702 File Offset: 0x00036902
		public unsafe float RepathRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCWalkTo.NativeFieldInfoPtr_RepathRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCWalkTo.NativeFieldInfoPtr_RepathRate)) = value;
			}
		}

		// Token: 0x1700240A RID: 9226
		// (get) Token: 0x0600772C RID: 30508 RVA: 0x00205530 File Offset: 0x00203730
		// (set) Token: 0x0600772D RID: 30509 RVA: 0x0003871D File Offset: 0x0003691D
		public unsafe float timeSinceLastPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCWalkTo.NativeFieldInfoPtr_timeSinceLastPath);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCWalkTo.NativeFieldInfoPtr_timeSinceLastPath)) = value;
			}
		}

		// Token: 0x04005154 RID: 20820
		private static readonly IntPtr NativeFieldInfoPtr_Target;

		// Token: 0x04005155 RID: 20821
		private static readonly IntPtr NativeFieldInfoPtr_RepathRate;

		// Token: 0x04005156 RID: 20822
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastPath;

		// Token: 0x04005157 RID: 20823
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005158 RID: 20824
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
