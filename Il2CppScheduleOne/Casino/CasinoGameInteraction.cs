using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004A2 RID: 1186
	public class CasinoGameInteraction : MonoBehaviour
	{
		// Token: 0x06006738 RID: 26424 RVA: 0x001D013C File Offset: 0x001CE33C
		// Note: this type is marked as 'beforefieldinit'.
		static CasinoGameInteraction()
		{
			Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "CasinoGameInteraction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr);
			CasinoGameInteraction.NativeFieldInfoPtr_GameName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, "GameName");
			CasinoGameInteraction.NativeFieldInfoPtr_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, "Players");
			CasinoGameInteraction.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, "IntObj");
			CasinoGameInteraction.NativeFieldInfoPtr_onLocalPlayerRequestJoin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, "onLocalPlayerRequestJoin");
			CasinoGameInteraction.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, 100676384);
			CasinoGameInteraction.NativeMethodInfoPtr_Hovered_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, 100676385);
			CasinoGameInteraction.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, 100676386);
			CasinoGameInteraction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr, 100676387);
		}

		// Token: 0x06006739 RID: 26425 RVA: 0x001D020C File Offset: 0x001CE40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208879, XrefRangeEnd = 208893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameInteraction.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600673A RID: 26426 RVA: 0x001D0240 File Offset: 0x001CE440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208893, XrefRangeEnd = 208898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameInteraction.NativeMethodInfoPtr_Hovered_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600673B RID: 26427 RVA: 0x001D0274 File Offset: 0x001CE474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208898, XrefRangeEnd = 208903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameInteraction.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600673C RID: 26428 RVA: 0x001D02A8 File Offset: 0x001CE4A8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGameInteraction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CasinoGameInteraction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameInteraction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600673D RID: 26429 RVA: 0x00030C05 File Offset: 0x0002EE05
		public CasinoGameInteraction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F0A RID: 7946
		// (get) Token: 0x0600673E RID: 26430 RVA: 0x001D02E4 File Offset: 0x001CE4E4
		// (set) Token: 0x0600673F RID: 26431 RVA: 0x00030C0E File Offset: 0x0002EE0E
		public unsafe string GameName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_GameName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_GameName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001F0B RID: 7947
		// (get) Token: 0x06006740 RID: 26432 RVA: 0x001D030C File Offset: 0x001CE50C
		// (set) Token: 0x06006741 RID: 26433 RVA: 0x00030C2D File Offset: 0x0002EE2D
		public unsafe CasinoGamePlayers Players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_Players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayers>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_Players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F0C RID: 7948
		// (get) Token: 0x06006742 RID: 26434 RVA: 0x001D033C File Offset: 0x001CE53C
		// (set) Token: 0x06006743 RID: 26435 RVA: 0x00030C4C File Offset: 0x0002EE4C
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F0D RID: 7949
		// (get) Token: 0x06006744 RID: 26436 RVA: 0x001D036C File Offset: 0x001CE56C
		// (set) Token: 0x06006745 RID: 26437 RVA: 0x00030C6B File Offset: 0x0002EE6B
		public unsafe Action<Player> onLocalPlayerRequestJoin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_onLocalPlayerRequestJoin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameInteraction.NativeFieldInfoPtr_onLocalPlayerRequestJoin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040046AA RID: 18090
		private static readonly IntPtr NativeFieldInfoPtr_GameName;

		// Token: 0x040046AB RID: 18091
		private static readonly IntPtr NativeFieldInfoPtr_Players;

		// Token: 0x040046AC RID: 18092
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x040046AD RID: 18093
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerRequestJoin;

		// Token: 0x040046AE RID: 18094
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040046AF RID: 18095
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Private_Void_0;

		// Token: 0x040046B0 RID: 18096
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x040046B1 RID: 18097
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
