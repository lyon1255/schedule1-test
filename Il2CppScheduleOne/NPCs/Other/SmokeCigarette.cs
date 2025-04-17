using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Animation;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Other
{
	// Token: 0x020002F5 RID: 757
	public class SmokeCigarette : MonoBehaviour
	{
		// Token: 0x06003930 RID: 14640 RVA: 0x0012A624 File Offset: 0x00128824
		// Note: this type is marked as 'beforefieldinit'.
		static SmokeCigarette()
		{
			Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Other", "SmokeCigarette");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr);
			SmokeCigarette.NativeFieldInfoPtr_Npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, "Npc");
			SmokeCigarette.NativeFieldInfoPtr_CigarettePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, "CigarettePrefab");
			SmokeCigarette.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, "Anim");
			SmokeCigarette.NativeFieldInfoPtr_cigarette = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, "cigarette");
			SmokeCigarette.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, 100669952);
			SmokeCigarette.NativeMethodInfoPtr_Begin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, 100669953);
			SmokeCigarette.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, 100669954);
			SmokeCigarette.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr, 100669955);
		}

		// Token: 0x06003931 RID: 14641 RVA: 0x0012A6F4 File Offset: 0x001288F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141820, XrefRangeEnd = 141828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeCigarette.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003932 RID: 14642 RVA: 0x0012A728 File Offset: 0x00128928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141828, XrefRangeEnd = 141840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeCigarette.NativeMethodInfoPtr_Begin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003933 RID: 14643 RVA: 0x0012A75C File Offset: 0x0012895C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141840, XrefRangeEnd = 141854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeCigarette.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003934 RID: 14644 RVA: 0x0012A790 File Offset: 0x00128990
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmokeCigarette() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmokeCigarette>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokeCigarette.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003935 RID: 14645 RVA: 0x0001D63F File Offset: 0x0001B83F
		public SmokeCigarette(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x06003936 RID: 14646 RVA: 0x0012A7CC File Offset: 0x001289CC
		// (set) Token: 0x06003937 RID: 14647 RVA: 0x0001D648 File Offset: 0x0001B848
		public unsafe NPC Npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr_Npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr_Npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x06003938 RID: 14648 RVA: 0x0012A7FC File Offset: 0x001289FC
		// (set) Token: 0x06003939 RID: 14649 RVA: 0x0001D667 File Offset: 0x0001B867
		public unsafe GameObject CigarettePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr_CigarettePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr_CigarettePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x0600393A RID: 14650 RVA: 0x0012A82C File Offset: 0x00128A2C
		// (set) Token: 0x0600393B RID: 14651 RVA: 0x0001D686 File Offset: 0x0001B886
		public unsafe AvatarAnimation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x0600393C RID: 14652 RVA: 0x0012A85C File Offset: 0x00128A5C
		// (set) Token: 0x0600393D RID: 14653 RVA: 0x0001D6A5 File Offset: 0x0001B8A5
		public unsafe GameObject cigarette
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr_cigarette);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokeCigarette.NativeFieldInfoPtr_cigarette), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040025C0 RID: 9664
		private static readonly IntPtr NativeFieldInfoPtr_Npc;

		// Token: 0x040025C1 RID: 9665
		private static readonly IntPtr NativeFieldInfoPtr_CigarettePrefab;

		// Token: 0x040025C2 RID: 9666
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x040025C3 RID: 9667
		private static readonly IntPtr NativeFieldInfoPtr_cigarette;

		// Token: 0x040025C4 RID: 9668
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040025C5 RID: 9669
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Void_0;

		// Token: 0x040025C6 RID: 9670
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Void_0;

		// Token: 0x040025C7 RID: 9671
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
