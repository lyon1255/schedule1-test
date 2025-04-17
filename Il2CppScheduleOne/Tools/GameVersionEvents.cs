using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200053B RID: 1339
	public class GameVersionEvents : MonoBehaviour
	{
		// Token: 0x060076E7 RID: 30439 RVA: 0x00204830 File Offset: 0x00202A30
		// Note: this type is marked as 'beforefieldinit'.
		static GameVersionEvents()
		{
			Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "GameVersionEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr);
			GameVersionEvents.NativeFieldInfoPtr_onFullGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr, "onFullGame");
			GameVersionEvents.NativeFieldInfoPtr_onDemoGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr, "onDemoGame");
			GameVersionEvents.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr, 100678280);
			GameVersionEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr, 100678281);
		}

		// Token: 0x060076E8 RID: 30440 RVA: 0x002048B0 File Offset: 0x00202AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameVersionEvents.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076E9 RID: 30441 RVA: 0x002048E4 File Offset: 0x00202AE4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameVersionEvents() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameVersionEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076EA RID: 30442 RVA: 0x00038513 File Offset: 0x00036713
		public GameVersionEvents(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023F8 RID: 9208
		// (get) Token: 0x060076EB RID: 30443 RVA: 0x00204920 File Offset: 0x00202B20
		// (set) Token: 0x060076EC RID: 30444 RVA: 0x0003851C File Offset: 0x0003671C
		public unsafe UnityEvent onFullGame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameVersionEvents.NativeFieldInfoPtr_onFullGame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameVersionEvents.NativeFieldInfoPtr_onFullGame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023F9 RID: 9209
		// (get) Token: 0x060076ED RID: 30445 RVA: 0x00204950 File Offset: 0x00202B50
		// (set) Token: 0x060076EE RID: 30446 RVA: 0x0003853B File Offset: 0x0003673B
		public unsafe UnityEvent onDemoGame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameVersionEvents.NativeFieldInfoPtr_onDemoGame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameVersionEvents.NativeFieldInfoPtr_onDemoGame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400512F RID: 20783
		private static readonly IntPtr NativeFieldInfoPtr_onFullGame;

		// Token: 0x04005130 RID: 20784
		private static readonly IntPtr NativeFieldInfoPtr_onDemoGame;

		// Token: 0x04005131 RID: 20785
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005132 RID: 20786
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
