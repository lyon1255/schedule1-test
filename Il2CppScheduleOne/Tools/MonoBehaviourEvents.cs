using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200053F RID: 1343
	public class MonoBehaviourEvents : MonoBehaviour
	{
		// Token: 0x06007718 RID: 30488 RVA: 0x002051B0 File Offset: 0x002033B0
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBehaviourEvents()
		{
			Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "MonoBehaviourEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr);
			MonoBehaviourEvents.NativeFieldInfoPtr_onAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, "onAwake");
			MonoBehaviourEvents.NativeFieldInfoPtr_onStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, "onStart");
			MonoBehaviourEvents.NativeFieldInfoPtr_onUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, "onUpdate");
			MonoBehaviourEvents.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, 100678308);
			MonoBehaviourEvents.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, 100678309);
			MonoBehaviourEvents.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, 100678310);
			MonoBehaviourEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, 100678311);
		}

		// Token: 0x06007719 RID: 30489 RVA: 0x0020526C File Offset: 0x0020346C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231373, XrefRangeEnd = 231374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourEvents.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600771A RID: 30490 RVA: 0x002052A0 File Offset: 0x002034A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231374, XrefRangeEnd = 231375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourEvents.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600771B RID: 30491 RVA: 0x002052D4 File Offset: 0x002034D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231375, XrefRangeEnd = 231376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourEvents.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600771C RID: 30492 RVA: 0x00205308 File Offset: 0x00203508
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBehaviourEvents() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600771D RID: 30493 RVA: 0x00038674 File Offset: 0x00036874
		public MonoBehaviourEvents(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002405 RID: 9221
		// (get) Token: 0x0600771E RID: 30494 RVA: 0x00205344 File Offset: 0x00203544
		// (set) Token: 0x0600771F RID: 30495 RVA: 0x0003867D File Offset: 0x0003687D
		public unsafe UnityEvent onAwake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onAwake);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onAwake), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002406 RID: 9222
		// (get) Token: 0x06007720 RID: 30496 RVA: 0x00205374 File Offset: 0x00203574
		// (set) Token: 0x06007721 RID: 30497 RVA: 0x0003869C File Offset: 0x0003689C
		public unsafe UnityEvent onStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002407 RID: 9223
		// (get) Token: 0x06007722 RID: 30498 RVA: 0x002053A4 File Offset: 0x002035A4
		// (set) Token: 0x06007723 RID: 30499 RVA: 0x000386BB File Offset: 0x000368BB
		public unsafe UnityEvent onUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400514D RID: 20813
		private static readonly IntPtr NativeFieldInfoPtr_onAwake;

		// Token: 0x0400514E RID: 20814
		private static readonly IntPtr NativeFieldInfoPtr_onStart;

		// Token: 0x0400514F RID: 20815
		private static readonly IntPtr NativeFieldInfoPtr_onUpdate;

		// Token: 0x04005150 RID: 20816
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005151 RID: 20817
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005152 RID: 20818
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005153 RID: 20819
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
